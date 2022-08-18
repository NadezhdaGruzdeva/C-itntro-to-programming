double time = 0,
    v1 = 1,
    v2 = 2,
    vDog = 5; // скорости друзей и собаки

int count = 0; // счетчик

double  distance = 20,
    meetDistance = 10;

int friend = 2;

while (distance > meetDistance)
{
    if (friend == 1)
    {
        time = distance / (v1 + vDog);
        friend = 2;

    }
    else
    {
        time = distance / (v2 + vDog);
        friend = 1;
    }
distance = distance -time * (v1+v2);
count = count + 1;
}

  Console.WriteLine(count);
 
