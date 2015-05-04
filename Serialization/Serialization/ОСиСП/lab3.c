/*
4. Написать программу поиска заданной пользователем комбинации из m байт (m <255) во всех файлах текущего каталога. Пользователь задаёт имя каталога. Главный процесс открывает каталог
 и запускает для каждого файла каталога отдельный процесс поиска заданной комбинации из m байт. Каждый процесс выводит на экран свой pid, полный путь к файлу, общее число просмотренных байт
 и результаты (сколько раз найдена комбинация) поиска. Число одновременно работающих процессов не должно превышать N (вводится пользователем). Проверить работу программы для каталога /etc
 и строки ifconfig.
*/
#include <stdlib.h>
#include <dirent.h>
#include <sys/stat.h>
#include <stdio.h>
#include <unistd.h>
#include <string.h>
#include <errno.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <fcntl.h>
#include <libgen.h>

char*  name;
int num, N;


int obhod(char *name_dir, char *words);

int main (int argc, char ** argv)
{
    int error_code,result;

    name = basename(argv[0]);

    if (argc != 4)
    {
        fprintf(stderr, "%s:!Wrong number of arguments!\n", name);
        return 1;
    }

    N=atoi(argv[3]);

    num=1;
    obhod(argv[1],argv[2]);

    while((result = wait(NULL)) > 0)

        if (errno != ECHILD && result == -1)
        {
            error_code=errno;
            fprintf(stderr,"%d %s: Error: %s!\n", getpid(), name, strerror(error_code));
            exit(1);
        }

    return 0;
}

int find(char *fullpath, char *words)
{
    int error_code;
    FILE *F;

    if ((F=fopen(fullpath,"r"))==NULL )
    {
        error_code = errno;
        fprintf(stderr, "%d %s: Cannot open file `%s`: %s\n", getpid(), name, fullpath, strerror(error_code));
        exit(0);
    }

    char * buffer = 0;
    long length;

    if (F)
    {
        fseek (F, 0, SEEK_END);
        length = ftell (F);
        fseek (F, 0, SEEK_SET);
        buffer = malloc (length);
        if (buffer)
        {
            fread (buffer, 1, length, F);
        }
        if(fclose(F) == EOF)
        {
            error_code = errno;
            fprintf(stderr, "%d %s: Cannot close file `%s`: %s\n", getpid(), name, fullpath, strerror(error_code));
            exit(0);
        }
    }

    if (buffer)
    {
        char const *p = buffer;
        int count;
        for (count = 0; ; ++count) {
            p = strstr(p, words);
            if (!p)
                break;
            p++;
        }

        return count;
    }
    else{
        return 0;
    }


}

void fork_work(char *fullpath, int size, char *words)
{
    int result,error_code, n, stat_v;
    pid_t pid;

    if (num>=N)
    {
        if ((result=wait(&stat_v))>0)
            num--;
        if (result==-1)
        {
            error_code=errno;
            fprintf(stderr, "%d %s: Wait error: %s!\n", getpid(), name, strerror(error_code));
            exit(0);
        }
    }
    pid=fork();
    if (pid==-1)
    {
        fprintf(stderr, "%d %s: Fork error: %s\n", getpid(), name, strerror(error_code));
        exit(0);
    }
    else if (pid==0)
    {
        n=find(fullpath, words);
        printf("%d %s %d %d\n", getpid(), fullpath, size,n);
        fflush(stdout);
        exit(0);
    }
    else if (pid>0)
        num++;
}

int obhod(char *name_dir, char *words)
{
    DIR *dir;
    struct dirent *entry;
    struct stat statbuf;
    char *fullpath;
    int error_code;

    if ((dir=opendir(name_dir)) == NULL)
    {
        error_code = errno;
        fprintf(stderr, "%d %s: Cannot open directory `%s`: %s\n", getpid(), name, name_dir, strerror(error_code));
        return 1;
    }

    errno = 0;
    while ((entry = readdir(dir)) !=NULL)
    {
        if (!(fullpath = (char*)malloc(strlen(name_dir)+entry->d_reclen+10)))
        {
            error_code = errno;
            fprintf(stderr, "%d %s: malloc error: %s!\n", getpid(), name, strerror(error_code));
            exit(error_code);
        }
        if (strcmp(name_dir, "/")== 0)
            sprintf(fullpath, "%s%s", name_dir, entry->d_name);
        else
            sprintf(fullpath, "%s/%s", name_dir, entry->d_name);
        if (entry->d_type == DT_DIR)
        {
            if (strcmp(".", entry->d_name) && strcmp("..", entry->d_name))
                obhod(fullpath, words);
        }
        else if(entry->d_type == DT_REG)
        {
            if (stat(fullpath, &statbuf)!=0)
            {
                fprintf(stderr, "%d %s: stat error for file `%s`: %s\n", getpid(), name, fullpath, strerror(error_code));
                continue;
            }

            fork_work(fullpath, (int)statbuf.st_size, words);
        }
        free(fullpath);
        errno = 0;
    }

    if(errno != 0)
    {
        fprintf(stderr, "%d %s: readdir failed: %s\n", getpid(), name, strerror(error_code));
        return 1;
    }

    if(closedir(dir) !=0)
    {
        error_code = errno;
        fprintf(stderr, "%d %s: closedir error: %s\n", getpid(), name, strerror(error_code));
        return 1;
    }

    return 0;
}
