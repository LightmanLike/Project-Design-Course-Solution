################################################################################
# Automatically-generated file. Do not edit!
################################################################################

SHELL = cmd.exe

CG_TOOL_ROOT := D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS

GEN_OPTS__FLAG := 
GEN_CMDS__FLAG := 

ORDERED_OBJS += \
"./TCS34725_file.obj" \
"./main.obj" \
"./softi2c.obj" \
"./tm4c1294ncpdt_startup_ccs.obj" \
"./uartstdio.obj" \
"./vl6180x_i2c.obj" \
"../tm4c1294ncpdt.cmd" \
$(GEN_CMDS__FLAG) \
-llibc.a \
-l"C:/ti/TivaWare_C_Series-2.1.4.178/driverlib/ccs/Debug/driverlib.lib" \

-include ../makefile.init

RM := DEL /F
RMDIR := RMDIR /S/Q

# All of the sources participating in the build are defined here
-include sources.mk
-include subdir_vars.mk
-include subdir_rules.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(C55_DEPS)),)
-include $(C55_DEPS)
endif
ifneq ($(strip $(C_UPPER_DEPS)),)
-include $(C_UPPER_DEPS)
endif
ifneq ($(strip $(S67_DEPS)),)
-include $(S67_DEPS)
endif
ifneq ($(strip $(S62_DEPS)),)
-include $(S62_DEPS)
endif
ifneq ($(strip $(S_DEPS)),)
-include $(S_DEPS)
endif
ifneq ($(strip $(OPT_DEPS)),)
-include $(OPT_DEPS)
endif
ifneq ($(strip $(C??_DEPS)),)
-include $(C??_DEPS)
endif
ifneq ($(strip $(ASM_UPPER_DEPS)),)
-include $(ASM_UPPER_DEPS)
endif
ifneq ($(strip $(S??_DEPS)),)
-include $(S??_DEPS)
endif
ifneq ($(strip $(C64_DEPS)),)
-include $(C64_DEPS)
endif
ifneq ($(strip $(CXX_DEPS)),)
-include $(CXX_DEPS)
endif
ifneq ($(strip $(S64_DEPS)),)
-include $(S64_DEPS)
endif
ifneq ($(strip $(INO_DEPS)),)
-include $(INO_DEPS)
endif
ifneq ($(strip $(CLA_DEPS)),)
-include $(CLA_DEPS)
endif
ifneq ($(strip $(S55_DEPS)),)
-include $(S55_DEPS)
endif
ifneq ($(strip $(SV7A_DEPS)),)
-include $(SV7A_DEPS)
endif
ifneq ($(strip $(C62_DEPS)),)
-include $(C62_DEPS)
endif
ifneq ($(strip $(C67_DEPS)),)
-include $(C67_DEPS)
endif
ifneq ($(strip $(PDE_DEPS)),)
-include $(PDE_DEPS)
endif
ifneq ($(strip $(K_DEPS)),)
-include $(K_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
ifneq ($(strip $(CC_DEPS)),)
-include $(CC_DEPS)
endif
ifneq ($(strip $(C++_DEPS)),)
-include $(C++_DEPS)
endif
ifneq ($(strip $(C43_DEPS)),)
-include $(C43_DEPS)
endif
ifneq ($(strip $(S43_DEPS)),)
-include $(S43_DEPS)
endif
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(CPP_DEPS)),)
-include $(CPP_DEPS)
endif
ifneq ($(strip $(SA_DEPS)),)
-include $(SA_DEPS)
endif
endif

-include ../makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
EXE_OUTPUTS += \
file_first.out \

EXE_OUTPUTS__QUOTED += \
"file_first.out" \

BIN_OUTPUTS += \
file_first.hex \

BIN_OUTPUTS__QUOTED += \
"file_first.hex" \


# All Target
all: file_first.out

# Tool invocations
file_first.out: $(OBJS) $(CMD_SRCS) $(GEN_CMDS)
	@echo 'Building target: "$@"'
	@echo 'Invoking: ARM Linker'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 -me -g --gcc --define=ccs="ccs" --define=PART_TM4C1294NCPDT --display_error_number --diag_wrap=off --diag_warning=225 --abi=eabi -z -m"file_first.map" --heap_size=0 --stack_size=512 -i"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/lib" -i"C:/ti/TivaWare_C_Series-2.1.4.178/utils" -i"C:/ti/TivaWare_C_Series-2.1.4.178" -i"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/include" --reread_libs --warn_sections --display_error_number --diag_wrap=off --xml_link_info="file_first_linkInfo.xml" --rom_model -o "file_first.out" $(ORDERED_OBJS)
	@echo 'Finished building target: "$@"'
	@echo ' '

file_first.hex: $(EXE_OUTPUTS)
	@echo 'Building files: $(strip $(EXE_OUTPUTS__QUOTED))'
	@echo 'Invoking: ARM Hex Utility'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armhex"  -o "file_first.hex" $(EXE_OUTPUTS__QUOTED)
	@echo 'Finished building: $(strip $(EXE_OUTPUTS__QUOTED))'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(BIN_OUTPUTS__QUOTED)$(EXE_OUTPUTS__QUOTED)
	-$(RM) "TCS34725_file.obj" "main.obj" "softi2c.obj" "tm4c1294ncpdt_startup_ccs.obj" "uartstdio.obj" "vl6180x_i2c.obj" 
	-$(RM) "TCS34725_file.d" "main.d" "softi2c.d" "tm4c1294ncpdt_startup_ccs.d" "uartstdio.d" "vl6180x_i2c.d" 
	-@echo 'Finished clean'
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY:

-include ../makefile.targets

