### cade bootloader GUI

打开cade.exe
选择要烧录的文件(支持拖拽)
选择设备类型(仅Atmel AVR类型的单片机需要手动指定)
插入单片机，等待识别
点击烧录(或勾选自动烧录后识别成功单片机自动烧写固件)

v0.5更新:
引入QMK_Toolbox架构（https://github.com/qmk/qmk_toolbox）
自动识别插入的设备
勾选自动烧录后当插入已知设备并进入bootloader模式时自动刷入选择的固件