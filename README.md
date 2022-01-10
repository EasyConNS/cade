### cade avrdude GUI

打开cade.exe
选择要烧录的文件(支持拖拽)
选择设备端口
选择设备类型(目前仅支持32u4和16u2的板子)
点击Flash!

v0.2update:增加高级功能:
可手动指定刷入文件类型(auto,intel,raw)，默认auto自动识别，刷入失败时使用
可直接刷入eeprom(如编译后的伊机控脚本)
一键擦除单片机(危险操作)
note:刷入flash/eeprom时可能会失败，原因不明，这时候可以在高级功能中的下拉框选择Raw(刷入eeprom时)或者Intel Hex(刷入flash时)，然后再次刷入