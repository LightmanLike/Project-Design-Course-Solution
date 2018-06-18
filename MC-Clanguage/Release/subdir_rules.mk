################################################################################
# Automatically-generated file. Do not edit!
################################################################################

SHELL = cmd.exe

# Each subdirectory must supply rules for building sources it contributes
TCS34725_file.obj: ../TCS34725_file.c $(GEN_OPTS) | $(GEN_HDRS)
	@echo 'Building file: "$<"'
	@echo 'Invoking: ARM Compiler'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 -me -O2 --include_path="D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/include" --gcc --define=ccs="ccs" --define=PART_TM4C1294NCPDT --display_error_number --diag_wrap=off --diag_warning=225 --abi=eabi --preproc_with_compile --preproc_dependency="TCS34725_file.d_raw" $(GEN_OPTS__FLAG) "$<"
	@echo 'Finished building: "$<"'
	@echo ' '

main.obj: ../main.c $(GEN_OPTS) | $(GEN_HDRS)
	@echo 'Building file: "$<"'
	@echo 'Invoking: ARM Compiler'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 -me -O2 --include_path="D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/include" --gcc --define=ccs="ccs" --define=PART_TM4C1294NCPDT --display_error_number --diag_wrap=off --diag_warning=225 --abi=eabi --preproc_with_compile --preproc_dependency="main.d_raw" $(GEN_OPTS__FLAG) "$<"
	@echo 'Finished building: "$<"'
	@echo ' '

softi2c.obj: ../softi2c.c $(GEN_OPTS) | $(GEN_HDRS)
	@echo 'Building file: "$<"'
	@echo 'Invoking: ARM Compiler'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 -me -O2 --include_path="D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/include" --gcc --define=ccs="ccs" --define=PART_TM4C1294NCPDT --display_error_number --diag_wrap=off --diag_warning=225 --abi=eabi --preproc_with_compile --preproc_dependency="softi2c.d_raw" $(GEN_OPTS__FLAG) "$<"
	@echo 'Finished building: "$<"'
	@echo ' '

tm4c1294ncpdt_startup_ccs.obj: ../tm4c1294ncpdt_startup_ccs.c $(GEN_OPTS) | $(GEN_HDRS)
	@echo 'Building file: "$<"'
	@echo 'Invoking: ARM Compiler'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 -me -O2 --include_path="D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/include" --gcc --define=ccs="ccs" --define=PART_TM4C1294NCPDT --display_error_number --diag_wrap=off --diag_warning=225 --abi=eabi --preproc_with_compile --preproc_dependency="tm4c1294ncpdt_startup_ccs.d_raw" $(GEN_OPTS__FLAG) "$<"
	@echo 'Finished building: "$<"'
	@echo ' '

uartstdio.obj: ../uartstdio.c $(GEN_OPTS) | $(GEN_HDRS)
	@echo 'Building file: "$<"'
	@echo 'Invoking: ARM Compiler'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 -me -O2 --include_path="D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/include" --gcc --define=ccs="ccs" --define=PART_TM4C1294NCPDT --display_error_number --diag_wrap=off --diag_warning=225 --abi=eabi --preproc_with_compile --preproc_dependency="uartstdio.d_raw" $(GEN_OPTS__FLAG) "$<"
	@echo 'Finished building: "$<"'
	@echo ' '

vl6180x_i2c.obj: ../vl6180x_i2c.c $(GEN_OPTS) | $(GEN_HDRS)
	@echo 'Building file: "$<"'
	@echo 'Invoking: ARM Compiler'
	"D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/bin/armcl" -mv7M4 --code_state=16 --float_support=FPv4SPD16 -me -O2 --include_path="D:/ccsv8/ccsv8/tools/compiler/ti-cgt-arm_18.1.1.LTS/include" --gcc --define=ccs="ccs" --define=PART_TM4C1294NCPDT --display_error_number --diag_wrap=off --diag_warning=225 --abi=eabi --preproc_with_compile --preproc_dependency="vl6180x_i2c.d_raw" $(GEN_OPTS__FLAG) "$<"
	@echo 'Finished building: "$<"'
	@echo ' '


