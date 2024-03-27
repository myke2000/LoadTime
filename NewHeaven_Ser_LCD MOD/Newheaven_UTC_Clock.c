
        #include <Hardware_Setup.h>
        #include <RTC_DS1307.h>   // driver for the DS1307 RTC
        #include <manual_set_time.h>
        #include <Display_All.h>
        #include <AutoSetTime.h>
        #include <string.h>
        #include <stdio.h>
        #include <input.c>

        

        
      
        #define PB_Set_Time PIN_B3
        
        void GetDate(int *RawData[])
        {
           int MyMonth=RawData;
           
           printf("month = %d",MyMonth);
        }
   

   int append(int* s, char c) {
        int len = strlen(s);
        s[len] = c;
        s[len+1] = '\0';
        
        return s;
   }
   
   
int hr1;
char buffer [22]={0};  


    void main()
       {      
       
         
         
  
                putc (0xfe);
                putc (0x61); // rs232 baud  
                putc (0x04); // = 9600
                
                delay_ms(3000);       // wait for lcd to init
                putc (0xfe);
                putc (0x41); // Turn on display
                
                putc (0xfe);
                putc (0x51); // clear the screen               
                        
                putc (0xfe); // set briteness 0-8
                putc (0x53); 
                putc (0x08);              
               
                putc (0xfe); // set contrast 0-50
                putc (0x52); 
                putc (39);  
                
                Template();
                                             
                //Read_All_RTC_Regs_At_Start(); //read all ds1307 regs without display
                
                     //int day[2];



       while(true)
         {  

         static char date[25];
         static char Tday[2];
         static unsigned int pos=0;
         char inByte;
         //Read_All_RTC_Regs(); put back after testing
           if(kbhit())
           {
               
            
               fgets(buffer,PCdata);
               hr1 = buffer[0];

               printf("%c\r\n",hr1);
           
           }
            
   
             
      
           if(!input(PB_Set_Time))
            {
               printf("button HIT!!");
               Manual_Set_Time(); // this is where the switch psn is read  
            } 
            else
            {
            }
            //printf("while loop\r\n");
                       
      }//end while
}//main


