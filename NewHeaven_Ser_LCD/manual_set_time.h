
    
      

   
   /// This file is used to read the thumbwheel switch and 3 push buttons  /// 
   /// Start PB Increment PB Save PB                                       ///
   /// The seconds are zeroed when the minutes are entered                 ///
   ///                                                                     ///
   /// All the inputs are pulled up high so all the true input data is     ///
   /// tested as Low = true. Only the first 3 bits of the thumbwheel       ///
   /// switch are being used that allows for 8 different selections only   ///
   /// 5 are being used hours, minutes, day, month, and date               ///
   
  
   /// The day-of-week register in the DS1307 counts from 1 through 7      /// 
   /// It doesn't know anything about Sunday, Monday, etc.  It's just a    ///
   /// counter that is incremented every day at midnight.                  ///
   /// If you want the first day of the week to be Sunday and today is     ///
   /// Sunday set the day-of-week to the value 1.  If today is Monday set  ///
   /// the day-of-week to the value 2, etc.Then every time you read the    ///
   /// day of week from the DS1307 1 ==> Sunday 2 ==> Monday etc           ///
   ///                                                                     ///
   
   
    
      #define PB_increment pin_B4
      #define PB_Save_Time pin_B5
      
     
      int loop5 = 0;
      int value;
      int temp =0;
      
    void Template()
       {                                     
                putc (0xfe); 
                putc (0x45); // psn cmd
                putc (0x05); // psn                
                printf ("WB9IXS UTC");                
                putc (0xfe); 
                putc (0x45); // psn cmd
                putc (0x47); // psn 
                printf ("CLOCK");                 
                putc (0xfe); 
                putc (0x45); // psn cmd
                putc (0x14); //row1 
                printf ("UT   :  ");                
                putc (0xfe); 
                putc (0x45); // psn cmd
                putc (0x1d); //row1 
                printf ("CT   :  :  ");
               }    
             
    void Manual_Set_Time() {
                loop5 = 1; 
                value = input_b() & 0x07; // only read 1st 3 bits
                delay_ms(500);                                                  
    /* Value is the value read from the 1st 3 bits on the thumbwheel switch */
    /* Because the inputs are pulled high the values are inverted. for example*/
    /* PSN 0 has no contacts pulled low so the value is 0x07 PSN 1 has bit 0 */
    /* low so the value is 0x06 psn 2 has bit 2 low so the value is 0x05 and */
    /* so on                                                                 */
    
    
         switch(value ) {            
            case 7: //hour
                  temp=1;
                  putc (0xfe);
                  putc (0x51); // clear the screen
               while(loop5){
                 putc (0xFE);
                 putc (0x45);  // cursor psn cmd
                 putc (0x00);  // cursor psn 
                 printf("Hrs are 24hr format");
                 putc (0xFE);
                 putc (0x45);  // cursor psn cmd
                 putc (0x40);  // cursor psn 
                 printf("Hrs are CT time UTC");
                 putc (0xFE);
                 putc (0x45);  // cursor psn cmd
                 putc (0x14);  // cursor psn 
                 printf("time is automatic");
         // print the hours as they increment    
                putc (0xFE);
                putc (0x45);  // cursor psn cmd
                putc (0x54);  // cursor psn       
                printf (" Hours =-> %u",temp);
                delay_ms(100);
                  
                  if(!input(PB_increment)){temp ++;delay_ms(200);}
                     if (temp > 24){temp = 0;}
                        if(!input(PB_Save_Time)){
                        hour = (((temp/10) << 4) | (temp % 10));
                        //(((temp/10) << 4) | (temp % 10)); convert temp to BCD
                        Write_hours();
                        loop5 = 0;
                        temp=0;
                  // clear the area where the hours were setup 
                        putc (0xfe);
                        putc (0x51); // clear the screen
                        delay_ms(200);
                        Template();
                        return;
                        }//end if 
                         }//end while  
            
            case 6:   //minute
                  putc (0xfe);
                  putc (0x51); // clear the screen
               while(loop5){
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x00);  // cursor psn 
                  printf("Sec's are set to 0 ");
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x40);  // cursor psn 
                  printf("when min's are saved");
                  delay_ms(100);
            // print the minutes as they increment 
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x54);  // cursor psn   
                  printf (" Minutes =-> %u",temp);
                  delay_ms(100);
                 
                  if(!input(PB_increment)){temp ++;delay_ms(200);}  
                     if (temp > 59){temp = 0;}
                        if(!input(PB_Save_Time)){
                        minute = (((temp/10) << 4) | (temp % 10));
                        //(((temp/10) << 4) | (temp % 10)); convert temp to BCD
                        Write_minutes();
                        Write_seconds();
                        loop5 = 0;
                        temp=0;
            // clear the area where the hours were setup  
                        putc (0xfe);
                        putc (0x51); // clear the screen
                        delay_ms(200);
                        Template();
                        return;
                       }//end if
                       }//end while 
                       
           case 5:   //day
                  temp=1;
                  putc (0xfe);
                  putc (0x51); // clear the screen
                  delay_ms(200);
               while(loop5){
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x0);  // cursor psn 
                  printf ("1=Sun2=Mon3=Tue4=Wed");
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x40);  // cursor psn 
                  printf ("5=Thu6=Fri7=Sat");
            // print the day as they increment 
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x54);  // cursor psn   
                  printf ("Day =->%u",temp);
                  delay_ms(100);
                 
                  if(!input(PB_increment)){temp ++;delay_ms(300);}  
                     if (temp > 7){temp = 0;}
                        if(!input(PB_Save_Time)){
                        day = (((temp/10) << 4) | (temp % 10));
                        //(((temp/10) << 4) | (temp % 10)); convert temp to BCD
                        Write_days();
                        loop5 = 0;
                        temp=0;
            // clear the area where the hours were setup     
                         putc (0xfe);
                         putc (0x51); // clear the screen
                         delay_ms(200);
                         Template();
                        return;
                       }//end if
                       }//end while 
                       
            case 4:   //month
                  temp=1;
                  putc (0xfe);
                  putc (0x51); // clear the screen
                  delay_ms(200);
               while(loop5){
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x0);  // cursor psn 
                  printf ("Enter month 1-12");
                  
            // print the day as they increment 
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x54);  // cursor psn   
                  printf (" Month =->%u",temp);
                  delay_ms(100);
                 
                  if(!input(PB_increment)){temp ++;delay_ms(300);}  
                     if (temp > 12){temp = 0;}
                        if(!input(PB_Save_Time)){
                        month = (((temp/10) << 4) | (temp % 10));
                        //(((temp/10) << 4) | (temp % 10)); convert temp to BCD
                        Write_months();
                        loop5 = 0;
                        temp=0;
            // clear the area where the hours were setup     
                         putc (0xfe);
                         putc (0x51); // clear the screen
                         delay_ms(200);
                         Template();
                        return;
                       }//end if
                       }//end while 
                       
           case 3:   //date
                  temp=1;
                  putc (0xfe);
                  putc (0x51); // clear the screen
                  delay_ms(200);
               while(loop5){
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x0);  // cursor psn 
                  printf ("Enter Date 1-31");
                  
            // print the day as they increment 
                  putc (0xFE);
                  putc (0x45);  // cursor psn cmd
                  putc (0x54);  // cursor psn   
                  printf (" Date =->%u",temp);
                  delay_ms(100);
                 
                  if(!input(PB_increment)){temp ++;delay_ms(200);}  
                     if (temp > 31){temp = 0;}
                        if(!input(PB_Save_Time)){
                        date = (((temp/10) << 4) | (temp % 10));
                        //(((temp/10) << 4) | (temp % 10)); convert temp to BCD
                        Write_date();
                        loop5 = 0;
                        temp=0;
            // clear the area where the hours were setup     
                         putc (0xfe);
                         putc (0x51); // clear the screen
                         delay_ms(200);
                         Template();
                        return;
                       }//end if
                       }//end while 
            default: 
               loop5 = 0;
               temp=0;
               RETURN;
          }//end switch case  
      }//end set time
     
