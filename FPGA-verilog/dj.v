`timescale 1ns / 1ps

module duoji(clk,rst,switch,xin,mov);
input switch;

input clk,rst;
output xin;
output mov;
reg mov;

reg xin;
reg[20:0] timer;
reg[31:0] cnt;
reg[29:0] counter;
reg[30:0] T;
reg[10:0] state;
reg[16:0] times;

always @(posedge clk or posedge rst)
     if(!rst)
         begin
         counter = 0;
        
         
         T = 0;
        
         
         end

              
always @(posedge clk or posedge rst)
     if(!rst)
         begin
         
         timer = 0;
         cnt = 0;
   
         state =1;
         times = 0;
        
         end
     
     else if(switch == 1)//防止机械臂转动过程中打到物品
      begin  
           if(state == 1 )
                begin
                
                 if(timer <= 50000 + 33333)//30
                     begin
                     xin = 1;
                     timer <= timer + 1;
                     end
                 else if(timer < 250000)
                     begin
                     xin = 0;
                     timer <= timer + 1;
                     end
                 else if(timer == 250000)
                     begin
                     times = times + 1;
                     timer = 0;
                     if(times == 2000) //2000个pwm
                         begin
                         state = 2;
                         times = 0;
                         end
                     end
                 end
              else if(state == 2 )
                        begin

                        
                         if(timer <= 50000 + 66666)//60
                             begin
                             xin = 1;
                             timer <= timer + 1;
                             end
                         else if(timer < 250000)
                             begin
                             xin = 0;
                             timer <= timer + 1;
                             end
                         else if(timer == 250000)
                             begin
                             times = times + 1;
                             timer = 0;
                             if(times == 2000) 
                                 begin
                                 state = 3;
                                 times = 0;
                                 end
                             end
                         end
             else if(state == 3 )
                 begin

                
                   if(timer <= 50000 + 99999)//90
                      begin
                      xin = 1;
                      timer <= timer + 1;
                      end
                  else if(timer < 250000)
                      begin
                      xin = 0;
                      timer <= timer + 1;
                      end
                  else if(timer == 250000)
                      begin
                      times = times + 1;
                      timer = 0;
                      if(times == 2000)
                         begin
                         state = 4;
                         times = 0;
                         end
                      end
                  end
              else if(state == 4)
                         begin

                         
                          if(timer <= 50000 + 33333*4)//120
                              begin
                              xin = 1;
                              timer <= timer + 1;
                              end
                          else if(timer < 250000)
                              begin
                              xin = 0;
                              timer <= timer + 1;
                              end
                          else if(timer == 250000)
                              begin
                              times = times + 1;
                              timer = 0;
                              if(times == 2000) 
                                  begin
                                  state = 5;
                                  times = 0;
                                  end
                              end
                          end
             else if(state == 5 )
                     begin

                    
                       if(timer <= 50000 + 33333*5)//150
                          begin
                          xin = 1;
                          timer <= timer + 1;
                          end
                      else if(timer < 250000)
                          begin
                          xin = 0;
                          timer <= timer + 1;
                          end
                      else if(timer == 250000)
                          begin
                          times = times + 1;
                          timer = 0;
                          if(times == 2000)
                             begin
                             state = 6;
                             times = 0;
                             end
                          end
                      end
                  else if(state == 6 && switch == 1)
                             begin

                             
                              if(timer <= 50000 + 33333*6)//180
                                  begin
                                  xin = 1;
                                  timer <= timer + 1;
                                  end
                              else if(timer < 250000)
                                  begin
                                  xin = 0;
                                  timer <= timer + 1;
                                  end
                              else if(timer == 250000)
                                  begin
                                  times = times + 1;
                                  timer = 0;
                                  if(times == 2000) 
                                      begin
                                      state = 7;
                                      times = 0;
                                      end
                                  end
                              end

                         else if(state == 7 )
                                    begin

                                  
                                     if(timer <= 50000 + 33333*5)
                                         begin
                                         xin = 1;
                                         timer <= timer + 1;
                                         end
                                     else if(timer < 250000)
                                         begin
                                         xin = 0;
                                         timer <= timer + 1;
                                         end
                                     else if(timer == 250000)
                                         begin
                                         times = times + 1;
                                         timer = 0;
                                         if(times == 2000) 
                                             begin
                                             state = 8;
                                             times = 0;
                                             end
                                         end
                                     end
                                  else if(state == 8)
                                            begin
                                            
                                             if(timer <= 50000 + 33333*4)
                                                 begin
                                                 xin = 1;
                                                 timer <= timer + 1;
                                                 end
                                             else if(timer < 250000)
                                                 begin
                                                 xin = 0;
                                                 timer <= timer + 1;
                                                 end
                                             else if(timer == 250000)
                                                 begin
                                                 times = times + 1;
                                                 timer = 0;
                                                 if(times == 2000) 
                                                     begin
                                                     state = 9;
                                                     times = 0;
                                                     end
                                                 end
                                             end
                                 else if(state == 9)
                                     begin
                                      

                                       if(timer <= 50000 +33333*3)
                                          begin
                                          xin = 1;
                                          timer <= timer + 1;
                                          end
                                      else if(timer < 250000)
                                          begin
                                          xin = 0;
                                          timer <= timer + 1;
                                          end
                                      else if(timer == 250000)
                                          begin
                                          times = times + 1;
                                          timer = 0;
                                          if(times == 2000)
                                             begin
                                             state = 10;
                                             times = 0;
                                             end
                                          end
                                      end
                                  else if(state == 10 )
                                             begin

                                             
                                              if(timer <= 50000 + 33333*2)
                                                  begin
                                                  xin = 1;
                                                  timer <= timer + 1;
                                                  end
                                              else if(timer < 250000)
                                                  begin
                                                  xin = 0;
                                                  timer <= timer + 1;
                                                  end
                                              else if(timer == 250000)
                                                  begin
                                                  times = times + 1;
                                                  timer = 0;
                                                  if(times == 2000) 
                                                      begin
                                                      state = 11;
                                                      times = 0;
                                                      end
                                                  end
                                              end
                                 else if(state == 11)
                                         begin

                                    
                                           if(timer <= 50000 +33333)
                                              begin
                                              xin = 1;
                                              timer <= timer + 1;
                                              end
                                          else if(timer < 250000)
                                              begin
                                              xin = 0;
                                              timer <= timer + 1;
                                              end
                                          else if(timer == 250000)
                                              begin
                                              times = times + 1;
                                              timer = 0;
                                              if(times == 2000)
                                                 begin
                                                 state = 12;
                                                 times = 0;
                                                 end
                                              end
                                          end
                             else if(state == 12 )
                                                 begin

                                                 
                                                  if(timer <= 50000)
                                                      begin
                                                      xin = 1;
                                                      timer <= timer + 1;
                                                      end
                                                  else if(timer < 250000)
                                                      begin
                                                      xin = 0;
                                                      timer <= timer + 1;
                                                      end
                                                  else if(timer == 250000)
                                                      begin
                                                      times = times + 1;
                                                      timer = 0;
                                                      if(times == 2000) 
                                                          begin
                                                          state = 1;
                                                          times = 0;
                                                          end
                                                      end
                                                  end         
                            
                          


      end             
      
endmodule                
  
  
    
/*
input switch1;
input switch2;
output xin;
output led;
reg led;
reg xin;
input clk;
input rst;

reg[39:0] timer;
reg[39:0] timer2;
reg[39:0] range;
reg[1:0] flag;


always @(posedge clk or posedge rst)
    if(!rst)
	    begin
	    timer <= 40'b0;
		timer2 <= 40'b0;
		flag <= 0;
		led <= 0;
		range <= 0;
		end

    else if(switch1 == 1 && switch2 == 1)
	    begin 
	    if(range < 100000000 )
		    begin
			
			range <= range + 1;
			timer <= timer + 1;
			led <= 1;
			if(timer < 200000)
			    begin
				xin <= 1;
			
				
				end
			else if(timer == 200000)
			    begin
				xin <= 0;
				
				end
			else if(timer < 300000)
			    begin
				xin <= 0;
				end
			else if(timer == 300000)
			    begin
				timer  <= 0;
				
				end
			end
		else if(range == 100000000)
		    begin
			range <= 0;
	        timer <= 0;
			end
        end

    else if(switch2 == 1)
	    begin
	    if(range < 100000000 )
		    begin
			
			range <= range + 1;
			timer <= timer + 1;
			led <= 1;
			if(timer < 5000)
			    begin
				xin <= 1;
			
				
				end
			else if(timer == 5000)
			    begin
				xin <= 0;
				
				end
			else if(timer < 300000)
			    begin
				xin <= 0;
				end
			else if(timer == 300000)
			    begin
				timer  <= 0;
				
				end
			end
		else if(range == 100000000)
		    begin
			range <= 0;
	        timer <= 0;
			end
		end
endmodule
	else 
	begin
	    if(range < 100000000 )
		    begin
			
			range <= range + 1;
			timer <= timer + 1;
			led <= 1;
			if(timer < 200000)
			    begin
				xin <= 1;
			
				
				end
			else if(timer == 200000)
			    begin
				xin <= 0;
				
				end
			else if(timer < 300000)
			    begin
				xin <= 0;
				end
			else if(timer == 300000)
			    begin
				timer  <= 0;
				
				end
			end
			
		else if(range < 200000000)
			begin
			range <= range + 1;
			timer <= timer + 1;
			led <= 0;
			if(timer < 5000)
			    begin
				xin <= 1;
		        end
			else if(timer == 5000)
			    begin
				xin <= 1;
				
				end
			else if(timer < 300000)
			    begin
				xin <= 0;
				end
			else if(timer == 300000)
			    begin
				timer  <= 0;
				
				end
			end    
		else if(range == 2000000000)
		    begin
			    range <= 0;
				timer <= 0;
			end
			
    end*/
