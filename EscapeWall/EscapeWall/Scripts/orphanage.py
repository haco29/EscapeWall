import serial # you need to install the pySerial :pyserial.sourceforge.net
import time
import sys
# your Serial port should be different!
# arduino = serial.Serial('COM3', 9600)

def onOffFunction():
  print (len(sys.argv))
  print ("Enter Password/off/bye")
  #command = input("Enter your password: ");
  return (1);
  if command =="1234":
    print ("Password is correct :)")
    time.sleep(1) 
    arduino.write(b'H') 
    onOffFunction()
  elif command =="off":
    print ("The LED is off...")
    time.sleep(1) 
    arduino.write(b'L')
    onOffFunction()
  elif command =="bye":
    print ("See You!...")
    time.sleep(1) 
    arduino.close()
  else:
    print ("Wrong password :(")
    onOffFunction()

time.sleep(2) #waiting the initialization...

onOffFunction()



