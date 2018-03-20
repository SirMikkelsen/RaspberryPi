BROADCAST_TO_PORT = 7000
import time
from socket import *
from datetime import datetime
import smbus
import json

bus = smbus.SMBus(1)

def readbus(addr, peripheral):
        bus.write_byte(addr, peripheral)
        return bus.read_byte(addr)

s = socket(AF_INET, SOCK_DGRAM)
#s.bind(('', 14593))     # (ip, port)
# no explicit bind: will bind to default IP + random port
s.setsockopt(SOL_SOCKET, SO_BROADCAST, 1)
while True:
        #msg = "lys {}".format(readbus(0x48, 0x00))
        lys = readbus(0x48, 0x00)
        msg = json.dumps({"lys": lys})
        s.sendto(bytes(msg, "UTF-8"), ('<broadcast>', BROADCAST_TO_PORT))
        print(msg)
        time.sleep(1)

        bus = smbus.SMBus(1)
