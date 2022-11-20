int count =0;
int disstance = 10000;
int first_speed_friend = 1;
int second_speed_friend = 2;
int dog_speed = 5;
int friend = 2;
int time = 1;
while (disstance>10) {
    if (friend ==1) {
        time = disstance/(first_speed_friend + dog_speed);
        friend = 2;
    }
    else {
        time = disstance/(second_speed_friend + dog_speed);
        friend = 1;
    }
    disstance = disstance - (first_speed_friend + second_speed_friend)*time;
    count++;

}
Console.WriteLine("Собака пробежит " + count + " раз");
