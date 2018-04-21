import serial # you need to install the pySerial :pyserial.sourceforge.net
import time
import sys
# your Serial port should be different!
arduino = serial.Serial('COM3', 9600)

def onOffFunction():
  # print (len(sys.argv))
  arduino.write(b'H')

time.sleep(2) #waiting the initialization...

onOffFunction()
