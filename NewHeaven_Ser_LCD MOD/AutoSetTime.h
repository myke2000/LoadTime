int Time=0;

void SetDate(int MyDay)
{
   date = (((MyDay/10) << 4) | (temp % 10));
   Write_date();
   
}


