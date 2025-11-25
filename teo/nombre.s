.global _start

.section .data
saludo:
	.string "Mi nombre es " 

nombre: 
	.string "Jose Melgares"

.section .text	
_start:
	mov	rax, 1
	mov	rdi, 1
	mov	rsi, offset saludo
	mov	rdx, 14
	syscall
	mov	rax, 1
	mov	rdi, 1
	mov	rsi, offset nombre
	mov 	rdx, 15
	syscall

	mov rax, 60
	mov rdi, 0
	syscall


