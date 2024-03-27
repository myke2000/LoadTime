



      
        #include <Hardware_Setup.h>
        #include <RTC_DS1307.h>   // driver for the DS1307 RTC
        #include <manual_set_time.h>
        #include <Display_All.h>
      
        #define PB_Set_Time PIN_B3
      
    
     
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
                                             
                Read_All_RTC_Regs_At_Start(); //read all ds1307 regs without display
                       
       while(TRUE)
         {  
            Read_All_RTC_Regs();
           if (!input (PB_Set_Time)) // this allows the thumbwheel to be read
              {
              Manual_Set_Time(); // this is where the switch psn is read  
             }                    
            
      }//end while
          }//main
