﻿using System.Diagnostics.CodeAnalysis;

namespace Gee.External.Capstone.X86 {
    /// <summary>
    ///     X86 Instruction Unique Identifier.
    /// </summary>
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum X86InstructionId {
        /// <summary>
        ///     Indicates an invalid, or an uninitialized, instruction.
        /// </summary>
        Invalid = 0,
        X86_INS_AAA,
        X86_INS_AAD,
        X86_INS_AAM,
        X86_INS_AAS,
        X86_INS_FABS,
        X86_INS_ADC,
        X86_INS_ADCX,
        X86_INS_ADD,
        X86_INS_ADDPD,
        X86_INS_ADDPS,
        X86_INS_ADDSD,
        X86_INS_ADDSS,
        X86_INS_ADDSUBPD,
        X86_INS_ADDSUBPS,
        X86_INS_FADD,
        X86_INS_FIADD,
        X86_INS_FADDP,
        X86_INS_ADOX,
        X86_INS_AESDECLAST,
        X86_INS_AESDEC,
        X86_INS_AESENCLAST,
        X86_INS_AESENC,
        X86_INS_AESIMC,
        X86_INS_AESKEYGENASSIST,
        X86_INS_AND,
        X86_INS_ANDN,
        X86_INS_ANDNPD,
        X86_INS_ANDNPS,
        X86_INS_ANDPD,
        X86_INS_ANDPS,
        X86_INS_ARPL,
        X86_INS_BEXTR,
        X86_INS_BLCFILL,
        X86_INS_BLCI,
        X86_INS_BLCIC,
        X86_INS_BLCMSK,
        X86_INS_BLCS,
        X86_INS_BLENDPD,
        X86_INS_BLENDPS,
        X86_INS_BLENDVPD,
        X86_INS_BLENDVPS,
        X86_INS_BLSFILL,
        X86_INS_BLSI,
        X86_INS_BLSIC,
        X86_INS_BLSMSK,
        X86_INS_BLSR,
        X86_INS_BOUND,
        X86_INS_BSF,
        X86_INS_BSR,
        X86_INS_BSWAP,
        X86_INS_BT,
        X86_INS_BTC,
        X86_INS_BTR,
        X86_INS_BTS,
        X86_INS_BZHI,
        X86_INS_CALL,
        X86_INS_CBW,
        X86_INS_CDQ,
        X86_INS_CDQE,
        X86_INS_FCHS,
        X86_INS_CLAC,
        X86_INS_CLC,
        X86_INS_CLD,
        X86_INS_CLFLUSH,
        X86_INS_CLFLUSHOPT,
        X86_INS_CLGI,
        X86_INS_CLI,
        X86_INS_CLTS,
        X86_INS_CLWB,
        X86_INS_CMC,
        X86_INS_CMOVA,
        X86_INS_CMOVAE,
        X86_INS_CMOVB,
        X86_INS_CMOVBE,
        X86_INS_FCMOVBE,
        X86_INS_FCMOVB,
        X86_INS_CMOVE,
        X86_INS_FCMOVE,
        X86_INS_CMOVG,
        X86_INS_CMOVGE,
        X86_INS_CMOVL,
        X86_INS_CMOVLE,
        X86_INS_FCMOVNBE,
        X86_INS_FCMOVNB,
        X86_INS_CMOVNE,
        X86_INS_FCMOVNE,
        X86_INS_CMOVNO,
        X86_INS_CMOVNP,
        X86_INS_FCMOVNU,
        X86_INS_CMOVNS,
        X86_INS_CMOVO,
        X86_INS_CMOVP,
        X86_INS_FCMOVU,
        X86_INS_CMOVS,
        X86_INS_CMP,
        X86_INS_CMPSB,
        X86_INS_CMPSQ,
        X86_INS_CMPSW,
        X86_INS_CMPXCHG16B,
        X86_INS_CMPXCHG,
        X86_INS_CMPXCHG8B,
        X86_INS_COMISD,
        X86_INS_COMISS,
        X86_INS_FCOMP,
        X86_INS_FCOMIP,
        X86_INS_FCOMI,
        X86_INS_FCOM,
        X86_INS_FCOS,
        X86_INS_CPUID,
        X86_INS_CQO,
        X86_INS_CRC32,
        X86_INS_CVTDQ2PD,
        X86_INS_CVTDQ2PS,
        X86_INS_CVTPD2DQ,
        X86_INS_CVTPD2PS,
        X86_INS_CVTPS2DQ,
        X86_INS_CVTPS2PD,
        X86_INS_CVTSD2SI,
        X86_INS_CVTSD2SS,
        X86_INS_CVTSI2SD,
        X86_INS_CVTSI2SS,
        X86_INS_CVTSS2SD,
        X86_INS_CVTSS2SI,
        X86_INS_CVTTPD2DQ,
        X86_INS_CVTTPS2DQ,
        X86_INS_CVTTSD2SI,
        X86_INS_CVTTSS2SI,
        X86_INS_CWD,
        X86_INS_CWDE,
        X86_INS_DAA,
        X86_INS_DAS,
        X86_INS_DATA16,
        X86_INS_DEC,
        X86_INS_DIV,
        X86_INS_DIVPD,
        X86_INS_DIVPS,
        X86_INS_FDIVR,
        X86_INS_FIDIVR,
        X86_INS_FDIVRP,
        X86_INS_DIVSD,
        X86_INS_DIVSS,
        X86_INS_FDIV,
        X86_INS_FIDIV,
        X86_INS_FDIVP,
        X86_INS_DPPD,
        X86_INS_DPPS,
        X86_INS_RET,
        X86_INS_ENCLS,
        X86_INS_ENCLU,
        X86_INS_ENTER,
        X86_INS_EXTRACTPS,
        X86_INS_EXTRQ,
        X86_INS_F2XM1,
        X86_INS_LCALL,
        X86_INS_LJMP,
        X86_INS_FBLD,
        X86_INS_FBSTP,
        X86_INS_FCOMPP,
        X86_INS_FDECSTP,
        X86_INS_FEMMS,
        X86_INS_FFREE,
        X86_INS_FICOM,
        X86_INS_FICOMP,
        X86_INS_FINCSTP,
        X86_INS_FLDCW,
        X86_INS_FLDENV,
        X86_INS_FLDL2E,
        X86_INS_FLDL2T,
        X86_INS_FLDLG2,
        X86_INS_FLDLN2,
        X86_INS_FLDPI,
        X86_INS_FNCLEX,
        X86_INS_FNINIT,
        X86_INS_FNOP,
        X86_INS_FNSTCW,
        X86_INS_FNSTSW,
        X86_INS_FPATAN,
        X86_INS_FPREM,
        X86_INS_FPREM1,
        X86_INS_FPTAN,
        X86_INS_FFREEP,
        X86_INS_FRNDINT,
        X86_INS_FRSTOR,
        X86_INS_FNSAVE,
        X86_INS_FSCALE,
        X86_INS_FSETPM,
        X86_INS_FSINCOS,
        X86_INS_FNSTENV,
        X86_INS_FXAM,
        X86_INS_FXRSTOR,
        X86_INS_FXRSTOR64,
        X86_INS_FXSAVE,
        X86_INS_FXSAVE64,
        X86_INS_FXTRACT,
        X86_INS_FYL2X,
        X86_INS_FYL2XP1,
        X86_INS_MOVAPD,
        X86_INS_MOVAPS,
        X86_INS_ORPD,
        X86_INS_ORPS,
        X86_INS_VMOVAPD,
        X86_INS_VMOVAPS,
        X86_INS_XORPD,
        X86_INS_XORPS,
        X86_INS_GETSEC,
        X86_INS_HADDPD,
        X86_INS_HADDPS,
        X86_INS_HLT,
        X86_INS_HSUBPD,
        X86_INS_HSUBPS,
        X86_INS_IDIV,
        X86_INS_FILD,
        X86_INS_IMUL,
        X86_INS_IN,
        X86_INS_INC,
        X86_INS_INSB,
        X86_INS_INSERTPS,
        X86_INS_INSERTQ,
        X86_INS_INSD,
        X86_INS_INSW,
        X86_INS_INT,
        X86_INS_INT1,
        X86_INS_INT3,
        X86_INS_INTO,
        X86_INS_INVD,
        X86_INS_INVEPT,
        X86_INS_INVLPG,
        X86_INS_INVLPGA,
        X86_INS_INVPCID,
        X86_INS_INVVPID,
        X86_INS_IRET,
        X86_INS_IRETD,
        X86_INS_IRETQ,
        X86_INS_FISTTP,
        X86_INS_FIST,
        X86_INS_FISTP,
        X86_INS_UCOMISD,
        X86_INS_UCOMISS,
        X86_INS_VCOMISD,
        X86_INS_VCOMISS,
        X86_INS_VCVTSD2SS,
        X86_INS_VCVTSI2SD,
        X86_INS_VCVTSI2SS,
        X86_INS_VCVTSS2SD,
        X86_INS_VCVTTSD2SI,
        X86_INS_VCVTTSD2USI,
        X86_INS_VCVTTSS2SI,
        X86_INS_VCVTTSS2USI,
        X86_INS_VCVTUSI2SD,
        X86_INS_VCVTUSI2SS,
        X86_INS_VUCOMISD,
        X86_INS_VUCOMISS,
        X86_INS_JAE,
        X86_INS_JA,
        X86_INS_JBE,
        X86_INS_JB,
        X86_INS_JCXZ,
        X86_INS_JECXZ,
        X86_INS_JE,
        X86_INS_JGE,
        X86_INS_JG,
        X86_INS_JLE,
        X86_INS_JL,
        X86_INS_JMP,
        X86_INS_JNE,
        X86_INS_JNO,
        X86_INS_JNP,
        X86_INS_JNS,
        X86_INS_JO,
        X86_INS_JP,
        X86_INS_JRCXZ,
        X86_INS_JS,
        X86_INS_KANDB,
        X86_INS_KANDD,
        X86_INS_KANDNB,
        X86_INS_KANDND,
        X86_INS_KANDNQ,
        X86_INS_KANDNW,
        X86_INS_KANDQ,
        X86_INS_KANDW,
        X86_INS_KMOVB,
        X86_INS_KMOVD,
        X86_INS_KMOVQ,
        X86_INS_KMOVW,
        X86_INS_KNOTB,
        X86_INS_KNOTD,
        X86_INS_KNOTQ,
        X86_INS_KNOTW,
        X86_INS_KORB,
        X86_INS_KORD,
        X86_INS_KORQ,
        X86_INS_KORTESTB,
        X86_INS_KORTESTD,
        X86_INS_KORTESTQ,
        X86_INS_KORTESTW,
        X86_INS_KORW,
        X86_INS_KSHIFTLB,
        X86_INS_KSHIFTLD,
        X86_INS_KSHIFTLQ,
        X86_INS_KSHIFTLW,
        X86_INS_KSHIFTRB,
        X86_INS_KSHIFTRD,
        X86_INS_KSHIFTRQ,
        X86_INS_KSHIFTRW,
        X86_INS_KUNPCKBW,
        X86_INS_KXNORB,
        X86_INS_KXNORD,
        X86_INS_KXNORQ,
        X86_INS_KXNORW,
        X86_INS_KXORB,
        X86_INS_KXORD,
        X86_INS_KXORQ,
        X86_INS_KXORW,
        X86_INS_LAHF,
        X86_INS_LAR,
        X86_INS_LDDQU,
        X86_INS_LDMXCSR,
        X86_INS_LDS,
        X86_INS_FLDZ,
        X86_INS_FLD1,
        X86_INS_FLD,
        X86_INS_LEA,
        X86_INS_LEAVE,
        X86_INS_LES,
        X86_INS_LFENCE,
        X86_INS_LFS,
        X86_INS_LGDT,
        X86_INS_LGS,
        X86_INS_LIDT,
        X86_INS_LLDT,
        X86_INS_LMSW,
        X86_INS_OR,
        X86_INS_SUB,
        X86_INS_XOR,
        X86_INS_LODSB,
        X86_INS_LODSD,
        X86_INS_LODSQ,
        X86_INS_LODSW,
        X86_INS_LOOP,
        X86_INS_LOOPE,
        X86_INS_LOOPNE,
        X86_INS_RETF,
        X86_INS_RETFQ,
        X86_INS_LSL,
        X86_INS_LSS,
        X86_INS_LTR,
        X86_INS_XADD,
        X86_INS_LZCNT,
        X86_INS_MASKMOVDQU,
        X86_INS_MAXPD,
        X86_INS_MAXPS,
        X86_INS_MAXSD,
        X86_INS_MAXSS,
        X86_INS_MFENCE,
        X86_INS_MINPD,
        X86_INS_MINPS,
        X86_INS_MINSD,
        X86_INS_MINSS,
        X86_INS_CVTPD2PI,
        X86_INS_CVTPI2PD,
        X86_INS_CVTPI2PS,
        X86_INS_CVTPS2PI,
        X86_INS_CVTTPD2PI,
        X86_INS_CVTTPS2PI,
        X86_INS_EMMS,
        X86_INS_MASKMOVQ,
        X86_INS_MOVD,
        X86_INS_MOVDQ2Q,
        X86_INS_MOVNTQ,
        X86_INS_MOVQ2DQ,
        X86_INS_MOVQ,
        X86_INS_PABSB,
        X86_INS_PABSD,
        X86_INS_PABSW,
        X86_INS_PACKSSDW,
        X86_INS_PACKSSWB,
        X86_INS_PACKUSWB,
        X86_INS_PADDB,
        X86_INS_PADDD,
        X86_INS_PADDQ,
        X86_INS_PADDSB,
        X86_INS_PADDSW,
        X86_INS_PADDUSB,
        X86_INS_PADDUSW,
        X86_INS_PADDW,
        X86_INS_PALIGNR,
        X86_INS_PANDN,
        X86_INS_PAND,
        X86_INS_PAVGB,
        X86_INS_PAVGW,
        X86_INS_PCMPEQB,
        X86_INS_PCMPEQD,
        X86_INS_PCMPEQW,
        X86_INS_PCMPGTB,
        X86_INS_PCMPGTD,
        X86_INS_PCMPGTW,
        X86_INS_PEXTRW,
        X86_INS_PHADDSW,
        X86_INS_PHADDW,
        X86_INS_PHADDD,
        X86_INS_PHSUBD,
        X86_INS_PHSUBSW,
        X86_INS_PHSUBW,
        X86_INS_PINSRW,
        X86_INS_PMADDUBSW,
        X86_INS_PMADDWD,
        X86_INS_PMAXSW,
        X86_INS_PMAXUB,
        X86_INS_PMINSW,
        X86_INS_PMINUB,
        X86_INS_PMOVMSKB,
        X86_INS_PMULHRSW,
        X86_INS_PMULHUW,
        X86_INS_PMULHW,
        X86_INS_PMULLW,
        X86_INS_PMULUDQ,
        X86_INS_POR,
        X86_INS_PSADBW,
        X86_INS_PSHUFB,
        X86_INS_PSHUFW,
        X86_INS_PSIGNB,
        X86_INS_PSIGND,
        X86_INS_PSIGNW,
        X86_INS_PSLLD,
        X86_INS_PSLLQ,
        X86_INS_PSLLW,
        X86_INS_PSRAD,
        X86_INS_PSRAW,
        X86_INS_PSRLD,
        X86_INS_PSRLQ,
        X86_INS_PSRLW,
        X86_INS_PSUBB,
        X86_INS_PSUBD,
        X86_INS_PSUBQ,
        X86_INS_PSUBSB,
        X86_INS_PSUBSW,
        X86_INS_PSUBUSB,
        X86_INS_PSUBUSW,
        X86_INS_PSUBW,
        X86_INS_PUNPCKHBW,
        X86_INS_PUNPCKHDQ,
        X86_INS_PUNPCKHWD,
        X86_INS_PUNPCKLBW,
        X86_INS_PUNPCKLDQ,
        X86_INS_PUNPCKLWD,
        X86_INS_PXOR,
        X86_INS_MONITOR,
        X86_INS_MONTMUL,
        X86_INS_MOV,
        X86_INS_MOVABS,
        X86_INS_MOVBE,
        X86_INS_MOVDDUP,
        X86_INS_MOVDQA,
        X86_INS_MOVDQU,
        X86_INS_MOVHLPS,
        X86_INS_MOVHPD,
        X86_INS_MOVHPS,
        X86_INS_MOVLHPS,
        X86_INS_MOVLPD,
        X86_INS_MOVLPS,
        X86_INS_MOVMSKPD,
        X86_INS_MOVMSKPS,
        X86_INS_MOVNTDQA,
        X86_INS_MOVNTDQ,
        X86_INS_MOVNTI,
        X86_INS_MOVNTPD,
        X86_INS_MOVNTPS,
        X86_INS_MOVNTSD,
        X86_INS_MOVNTSS,
        X86_INS_MOVSB,
        X86_INS_MOVSD,
        X86_INS_MOVSHDUP,
        X86_INS_MOVSLDUP,
        X86_INS_MOVSQ,
        X86_INS_MOVSS,
        X86_INS_MOVSW,
        X86_INS_MOVSX,
        X86_INS_MOVSXD,
        X86_INS_MOVUPD,
        X86_INS_MOVUPS,
        X86_INS_MOVZX,
        X86_INS_MPSADBW,
        X86_INS_MUL,
        X86_INS_MULPD,
        X86_INS_MULPS,
        X86_INS_MULSD,
        X86_INS_MULSS,
        X86_INS_MULX,
        X86_INS_FMUL,
        X86_INS_FIMUL,
        X86_INS_FMULP,
        X86_INS_MWAIT,
        X86_INS_NEG,
        X86_INS_NOP,
        X86_INS_NOT,
        X86_INS_OUT,
        X86_INS_OUTSB,
        X86_INS_OUTSD,
        X86_INS_OUTSW,
        X86_INS_PACKUSDW,
        X86_INS_PAUSE,
        X86_INS_PAVGUSB,
        X86_INS_PBLENDVB,
        X86_INS_PBLENDW,
        X86_INS_PCLMULQDQ,
        X86_INS_PCMPEQQ,
        X86_INS_PCMPESTRI,
        X86_INS_PCMPESTRM,
        X86_INS_PCMPGTQ,
        X86_INS_PCMPISTRI,
        X86_INS_PCMPISTRM,
        X86_INS_PCOMMIT,
        X86_INS_PDEP,
        X86_INS_PEXT,
        X86_INS_PEXTRB,
        X86_INS_PEXTRD,
        X86_INS_PEXTRQ,
        X86_INS_PF2ID,
        X86_INS_PF2IW,
        X86_INS_PFACC,
        X86_INS_PFADD,
        X86_INS_PFCMPEQ,
        X86_INS_PFCMPGE,
        X86_INS_PFCMPGT,
        X86_INS_PFMAX,
        X86_INS_PFMIN,
        X86_INS_PFMUL,
        X86_INS_PFNACC,
        X86_INS_PFPNACC,
        X86_INS_PFRCPIT1,
        X86_INS_PFRCPIT2,
        X86_INS_PFRCP,
        X86_INS_PFRSQIT1,
        X86_INS_PFRSQRT,
        X86_INS_PFSUBR,
        X86_INS_PFSUB,
        X86_INS_PHMINPOSUW,
        X86_INS_PI2FD,
        X86_INS_PI2FW,
        X86_INS_PINSRB,
        X86_INS_PINSRD,
        X86_INS_PINSRQ,
        X86_INS_PMAXSB,
        X86_INS_PMAXSD,
        X86_INS_PMAXUD,
        X86_INS_PMAXUW,
        X86_INS_PMINSB,
        X86_INS_PMINSD,
        X86_INS_PMINUD,
        X86_INS_PMINUW,
        X86_INS_PMOVSXBD,
        X86_INS_PMOVSXBQ,
        X86_INS_PMOVSXBW,
        X86_INS_PMOVSXDQ,
        X86_INS_PMOVSXWD,
        X86_INS_PMOVSXWQ,
        X86_INS_PMOVZXBD,
        X86_INS_PMOVZXBQ,
        X86_INS_PMOVZXBW,
        X86_INS_PMOVZXDQ,
        X86_INS_PMOVZXWD,
        X86_INS_PMOVZXWQ,
        X86_INS_PMULDQ,
        X86_INS_PMULHRW,
        X86_INS_PMULLD,
        X86_INS_POP,
        X86_INS_POPAW,
        X86_INS_POPAL,
        X86_INS_POPCNT,
        X86_INS_POPF,
        X86_INS_POPFD,
        X86_INS_POPFQ,
        X86_INS_PREFETCH,
        X86_INS_PREFETCHNTA,
        X86_INS_PREFETCHT0,
        X86_INS_PREFETCHT1,
        X86_INS_PREFETCHT2,
        X86_INS_PREFETCHW,
        X86_INS_PSHUFD,
        X86_INS_PSHUFHW,
        X86_INS_PSHUFLW,
        X86_INS_PSLLDQ,
        X86_INS_PSRLDQ,
        X86_INS_PSWAPD,
        X86_INS_PTEST,
        X86_INS_PUNPCKHQDQ,
        X86_INS_PUNPCKLQDQ,
        X86_INS_PUSH,
        X86_INS_PUSHAW,
        X86_INS_PUSHAL,
        X86_INS_PUSHF,
        X86_INS_PUSHFD,
        X86_INS_PUSHFQ,
        X86_INS_RCL,
        X86_INS_RCPPS,
        X86_INS_RCPSS,
        X86_INS_RCR,
        X86_INS_RDFSBASE,
        X86_INS_RDGSBASE,
        X86_INS_RDMSR,
        X86_INS_RDPMC,
        X86_INS_RDRAND,
        X86_INS_RDSEED,
        X86_INS_RDTSC,
        X86_INS_RDTSCP,
        X86_INS_ROL,
        X86_INS_ROR,
        X86_INS_RORX,
        X86_INS_ROUNDPD,
        X86_INS_ROUNDPS,
        X86_INS_ROUNDSD,
        X86_INS_ROUNDSS,
        X86_INS_RSM,
        X86_INS_RSQRTPS,
        X86_INS_RSQRTSS,
        X86_INS_SAHF,
        X86_INS_SAL,
        X86_INS_SALC,
        X86_INS_SAR,
        X86_INS_SARX,
        X86_INS_SBB,
        X86_INS_SCASB,
        X86_INS_SCASD,
        X86_INS_SCASQ,
        X86_INS_SCASW,
        X86_INS_SETAE,
        X86_INS_SETA,
        X86_INS_SETBE,
        X86_INS_SETB,
        X86_INS_SETE,
        X86_INS_SETGE,
        X86_INS_SETG,
        X86_INS_SETLE,
        X86_INS_SETL,
        X86_INS_SETNE,
        X86_INS_SETNO,
        X86_INS_SETNP,
        X86_INS_SETNS,
        X86_INS_SETO,
        X86_INS_SETP,
        X86_INS_SETS,
        X86_INS_SFENCE,
        X86_INS_SGDT,
        X86_INS_SHA1MSG1,
        X86_INS_SHA1MSG2,
        X86_INS_SHA1NEXTE,
        X86_INS_SHA1RNDS4,
        X86_INS_SHA256MSG1,
        X86_INS_SHA256MSG2,
        X86_INS_SHA256RNDS2,
        X86_INS_SHL,
        X86_INS_SHLD,
        X86_INS_SHLX,
        X86_INS_SHR,
        X86_INS_SHRD,
        X86_INS_SHRX,
        X86_INS_SHUFPD,
        X86_INS_SHUFPS,
        X86_INS_SIDT,
        X86_INS_FSIN,
        X86_INS_SKINIT,
        X86_INS_SLDT,
        X86_INS_SMSW,
        X86_INS_SQRTPD,
        X86_INS_SQRTPS,
        X86_INS_SQRTSD,
        X86_INS_SQRTSS,
        X86_INS_FSQRT,
        X86_INS_STAC,
        X86_INS_STC,
        X86_INS_STD,
        X86_INS_STGI,
        X86_INS_STI,
        X86_INS_STMXCSR,
        X86_INS_STOSB,
        X86_INS_STOSD,
        X86_INS_STOSQ,
        X86_INS_STOSW,
        X86_INS_STR,
        X86_INS_FST,
        X86_INS_FSTP,
        X86_INS_FSTPNCE,
        X86_INS_FXCH,
        X86_INS_SUBPD,
        X86_INS_SUBPS,
        X86_INS_FSUBR,
        X86_INS_FISUBR,
        X86_INS_FSUBRP,
        X86_INS_SUBSD,
        X86_INS_SUBSS,
        X86_INS_FSUB,
        X86_INS_FISUB,
        X86_INS_FSUBP,
        X86_INS_SWAPGS,
        X86_INS_SYSCALL,
        X86_INS_SYSENTER,
        X86_INS_SYSEXIT,
        X86_INS_SYSRET,
        X86_INS_T1MSKC,
        X86_INS_TEST,
        X86_INS_UD2,
        X86_INS_FTST,
        X86_INS_TZCNT,
        X86_INS_TZMSK,
        X86_INS_FUCOMIP,
        X86_INS_FUCOMI,
        X86_INS_FUCOMPP,
        X86_INS_FUCOMP,
        X86_INS_FUCOM,
        X86_INS_UD2B,
        X86_INS_UNPCKHPD,
        X86_INS_UNPCKHPS,
        X86_INS_UNPCKLPD,
        X86_INS_UNPCKLPS,
        X86_INS_VADDPD,
        X86_INS_VADDPS,
        X86_INS_VADDSD,
        X86_INS_VADDSS,
        X86_INS_VADDSUBPD,
        X86_INS_VADDSUBPS,
        X86_INS_VAESDECLAST,
        X86_INS_VAESDEC,
        X86_INS_VAESENCLAST,
        X86_INS_VAESENC,
        X86_INS_VAESIMC,
        X86_INS_VAESKEYGENASSIST,
        X86_INS_VALIGND,
        X86_INS_VALIGNQ,
        X86_INS_VANDNPD,
        X86_INS_VANDNPS,
        X86_INS_VANDPD,
        X86_INS_VANDPS,
        X86_INS_VBLENDMPD,
        X86_INS_VBLENDMPS,
        X86_INS_VBLENDPD,
        X86_INS_VBLENDPS,
        X86_INS_VBLENDVPD,
        X86_INS_VBLENDVPS,
        X86_INS_VBROADCASTF128,
        X86_INS_VBROADCASTI32X4,
        X86_INS_VBROADCASTI64X4,
        X86_INS_VBROADCASTSD,
        X86_INS_VBROADCASTSS,
        X86_INS_VCOMPRESSPD,
        X86_INS_VCOMPRESSPS,
        X86_INS_VCVTDQ2PD,
        X86_INS_VCVTDQ2PS,
        X86_INS_VCVTPD2DQX,
        X86_INS_VCVTPD2DQ,
        X86_INS_VCVTPD2PSX,
        X86_INS_VCVTPD2PS,
        X86_INS_VCVTPD2UDQ,
        X86_INS_VCVTPH2PS,
        X86_INS_VCVTPS2DQ,
        X86_INS_VCVTPS2PD,
        X86_INS_VCVTPS2PH,
        X86_INS_VCVTPS2UDQ,
        X86_INS_VCVTSD2SI,
        X86_INS_VCVTSD2USI,
        X86_INS_VCVTSS2SI,
        X86_INS_VCVTSS2USI,
        X86_INS_VCVTTPD2DQX,
        X86_INS_VCVTTPD2DQ,
        X86_INS_VCVTTPD2UDQ,
        X86_INS_VCVTTPS2DQ,
        X86_INS_VCVTTPS2UDQ,
        X86_INS_VCVTUDQ2PD,
        X86_INS_VCVTUDQ2PS,
        X86_INS_VDIVPD,
        X86_INS_VDIVPS,
        X86_INS_VDIVSD,
        X86_INS_VDIVSS,
        X86_INS_VDPPD,
        X86_INS_VDPPS,
        X86_INS_VERR,
        X86_INS_VERW,
        X86_INS_VEXP2PD,
        X86_INS_VEXP2PS,
        X86_INS_VEXPANDPD,
        X86_INS_VEXPANDPS,
        X86_INS_VEXTRACTF128,
        X86_INS_VEXTRACTF32X4,
        X86_INS_VEXTRACTF64X4,
        X86_INS_VEXTRACTI128,
        X86_INS_VEXTRACTI32X4,
        X86_INS_VEXTRACTI64X4,
        X86_INS_VEXTRACTPS,
        X86_INS_VFMADD132PD,
        X86_INS_VFMADD132PS,
        X86_INS_VFMADDPD,
        X86_INS_VFMADD213PD,
        X86_INS_VFMADD231PD,
        X86_INS_VFMADDPS,
        X86_INS_VFMADD213PS,
        X86_INS_VFMADD231PS,
        X86_INS_VFMADDSD,
        X86_INS_VFMADD213SD,
        X86_INS_VFMADD132SD,
        X86_INS_VFMADD231SD,
        X86_INS_VFMADDSS,
        X86_INS_VFMADD213SS,
        X86_INS_VFMADD132SS,
        X86_INS_VFMADD231SS,
        X86_INS_VFMADDSUB132PD,
        X86_INS_VFMADDSUB132PS,
        X86_INS_VFMADDSUBPD,
        X86_INS_VFMADDSUB213PD,
        X86_INS_VFMADDSUB231PD,
        X86_INS_VFMADDSUBPS,
        X86_INS_VFMADDSUB213PS,
        X86_INS_VFMADDSUB231PS,
        X86_INS_VFMSUB132PD,
        X86_INS_VFMSUB132PS,
        X86_INS_VFMSUBADD132PD,
        X86_INS_VFMSUBADD132PS,
        X86_INS_VFMSUBADDPD,
        X86_INS_VFMSUBADD213PD,
        X86_INS_VFMSUBADD231PD,
        X86_INS_VFMSUBADDPS,
        X86_INS_VFMSUBADD213PS,
        X86_INS_VFMSUBADD231PS,
        X86_INS_VFMSUBPD,
        X86_INS_VFMSUB213PD,
        X86_INS_VFMSUB231PD,
        X86_INS_VFMSUBPS,
        X86_INS_VFMSUB213PS,
        X86_INS_VFMSUB231PS,
        X86_INS_VFMSUBSD,
        X86_INS_VFMSUB213SD,
        X86_INS_VFMSUB132SD,
        X86_INS_VFMSUB231SD,
        X86_INS_VFMSUBSS,
        X86_INS_VFMSUB213SS,
        X86_INS_VFMSUB132SS,
        X86_INS_VFMSUB231SS,
        X86_INS_VFNMADD132PD,
        X86_INS_VFNMADD132PS,
        X86_INS_VFNMADDPD,
        X86_INS_VFNMADD213PD,
        X86_INS_VFNMADD231PD,
        X86_INS_VFNMADDPS,
        X86_INS_VFNMADD213PS,
        X86_INS_VFNMADD231PS,
        X86_INS_VFNMADDSD,
        X86_INS_VFNMADD213SD,
        X86_INS_VFNMADD132SD,
        X86_INS_VFNMADD231SD,
        X86_INS_VFNMADDSS,
        X86_INS_VFNMADD213SS,
        X86_INS_VFNMADD132SS,
        X86_INS_VFNMADD231SS,
        X86_INS_VFNMSUB132PD,
        X86_INS_VFNMSUB132PS,
        X86_INS_VFNMSUBPD,
        X86_INS_VFNMSUB213PD,
        X86_INS_VFNMSUB231PD,
        X86_INS_VFNMSUBPS,
        X86_INS_VFNMSUB213PS,
        X86_INS_VFNMSUB231PS,
        X86_INS_VFNMSUBSD,
        X86_INS_VFNMSUB213SD,
        X86_INS_VFNMSUB132SD,
        X86_INS_VFNMSUB231SD,
        X86_INS_VFNMSUBSS,
        X86_INS_VFNMSUB213SS,
        X86_INS_VFNMSUB132SS,
        X86_INS_VFNMSUB231SS,
        X86_INS_VFRCZPD,
        X86_INS_VFRCZPS,
        X86_INS_VFRCZSD,
        X86_INS_VFRCZSS,
        X86_INS_VORPD,
        X86_INS_VORPS,
        X86_INS_VXORPD,
        X86_INS_VXORPS,
        X86_INS_VGATHERDPD,
        X86_INS_VGATHERDPS,
        X86_INS_VGATHERPF0DPD,
        X86_INS_VGATHERPF0DPS,
        X86_INS_VGATHERPF0QPD,
        X86_INS_VGATHERPF0QPS,
        X86_INS_VGATHERPF1DPD,
        X86_INS_VGATHERPF1DPS,
        X86_INS_VGATHERPF1QPD,
        X86_INS_VGATHERPF1QPS,
        X86_INS_VGATHERQPD,
        X86_INS_VGATHERQPS,
        X86_INS_VHADDPD,
        X86_INS_VHADDPS,
        X86_INS_VHSUBPD,
        X86_INS_VHSUBPS,
        X86_INS_VINSERTF128,
        X86_INS_VINSERTF32X4,
        X86_INS_VINSERTF32X8,
        X86_INS_VINSERTF64X2,
        X86_INS_VINSERTF64X4,
        X86_INS_VINSERTI128,
        X86_INS_VINSERTI32X4,
        X86_INS_VINSERTI32X8,
        X86_INS_VINSERTI64X2,
        X86_INS_VINSERTI64X4,
        X86_INS_VINSERTPS,
        X86_INS_VLDDQU,
        X86_INS_VLDMXCSR,
        X86_INS_VMASKMOVDQU,
        X86_INS_VMASKMOVPD,
        X86_INS_VMASKMOVPS,
        X86_INS_VMAXPD,
        X86_INS_VMAXPS,
        X86_INS_VMAXSD,
        X86_INS_VMAXSS,
        X86_INS_VMCALL,
        X86_INS_VMCLEAR,
        X86_INS_VMFUNC,
        X86_INS_VMINPD,
        X86_INS_VMINPS,
        X86_INS_VMINSD,
        X86_INS_VMINSS,
        X86_INS_VMLAUNCH,
        X86_INS_VMLOAD,
        X86_INS_VMMCALL,
        X86_INS_VMOVQ,
        X86_INS_VMOVDDUP,
        X86_INS_VMOVD,
        X86_INS_VMOVDQA32,
        X86_INS_VMOVDQA64,
        X86_INS_VMOVDQA,
        X86_INS_VMOVDQU16,
        X86_INS_VMOVDQU32,
        X86_INS_VMOVDQU64,
        X86_INS_VMOVDQU8,
        X86_INS_VMOVDQU,
        X86_INS_VMOVHLPS,
        X86_INS_VMOVHPD,
        X86_INS_VMOVHPS,
        X86_INS_VMOVLHPS,
        X86_INS_VMOVLPD,
        X86_INS_VMOVLPS,
        X86_INS_VMOVMSKPD,
        X86_INS_VMOVMSKPS,
        X86_INS_VMOVNTDQA,
        X86_INS_VMOVNTDQ,
        X86_INS_VMOVNTPD,
        X86_INS_VMOVNTPS,
        X86_INS_VMOVSD,
        X86_INS_VMOVSHDUP,
        X86_INS_VMOVSLDUP,
        X86_INS_VMOVSS,
        X86_INS_VMOVUPD,
        X86_INS_VMOVUPS,
        X86_INS_VMPSADBW,
        X86_INS_VMPTRLD,
        X86_INS_VMPTRST,
        X86_INS_VMREAD,
        X86_INS_VMRESUME,
        X86_INS_VMRUN,
        X86_INS_VMSAVE,
        X86_INS_VMULPD,
        X86_INS_VMULPS,
        X86_INS_VMULSD,
        X86_INS_VMULSS,
        X86_INS_VMWRITE,
        X86_INS_VMXOFF,
        X86_INS_VMXON,
        X86_INS_VPABSB,
        X86_INS_VPABSD,
        X86_INS_VPABSQ,
        X86_INS_VPABSW,
        X86_INS_VPACKSSDW,
        X86_INS_VPACKSSWB,
        X86_INS_VPACKUSDW,
        X86_INS_VPACKUSWB,
        X86_INS_VPADDB,
        X86_INS_VPADDD,
        X86_INS_VPADDQ,
        X86_INS_VPADDSB,
        X86_INS_VPADDSW,
        X86_INS_VPADDUSB,
        X86_INS_VPADDUSW,
        X86_INS_VPADDW,
        X86_INS_VPALIGNR,
        X86_INS_VPANDD,
        X86_INS_VPANDND,
        X86_INS_VPANDNQ,
        X86_INS_VPANDN,
        X86_INS_VPANDQ,
        X86_INS_VPAND,
        X86_INS_VPAVGB,
        X86_INS_VPAVGW,
        X86_INS_VPBLENDD,
        X86_INS_VPBLENDMB,
        X86_INS_VPBLENDMD,
        X86_INS_VPBLENDMQ,
        X86_INS_VPBLENDMW,
        X86_INS_VPBLENDVB,
        X86_INS_VPBLENDW,
        X86_INS_VPBROADCASTB,
        X86_INS_VPBROADCASTD,
        X86_INS_VPBROADCASTMB2Q,
        X86_INS_VPBROADCASTMW2D,
        X86_INS_VPBROADCASTQ,
        X86_INS_VPBROADCASTW,
        X86_INS_VPCLMULQDQ,
        X86_INS_VPCMOV,
        X86_INS_VPCMPB,
        X86_INS_VPCMPD,
        X86_INS_VPCMPEQB,
        X86_INS_VPCMPEQD,
        X86_INS_VPCMPEQQ,
        X86_INS_VPCMPEQW,
        X86_INS_VPCMPESTRI,
        X86_INS_VPCMPESTRM,
        X86_INS_VPCMPGTB,
        X86_INS_VPCMPGTD,
        X86_INS_VPCMPGTQ,
        X86_INS_VPCMPGTW,
        X86_INS_VPCMPISTRI,
        X86_INS_VPCMPISTRM,
        X86_INS_VPCMPQ,
        X86_INS_VPCMPUB,
        X86_INS_VPCMPUD,
        X86_INS_VPCMPUQ,
        X86_INS_VPCMPUW,
        X86_INS_VPCMPW,
        X86_INS_VPCOMB,
        X86_INS_VPCOMD,
        X86_INS_VPCOMPRESSD,
        X86_INS_VPCOMPRESSQ,
        X86_INS_VPCOMQ,
        X86_INS_VPCOMUB,
        X86_INS_VPCOMUD,
        X86_INS_VPCOMUQ,
        X86_INS_VPCOMUW,
        X86_INS_VPCOMW,
        X86_INS_VPCONFLICTD,
        X86_INS_VPCONFLICTQ,
        X86_INS_VPERM2F128,
        X86_INS_VPERM2I128,
        X86_INS_VPERMD,
        X86_INS_VPERMI2D,
        X86_INS_VPERMI2PD,
        X86_INS_VPERMI2PS,
        X86_INS_VPERMI2Q,
        X86_INS_VPERMIL2PD,
        X86_INS_VPERMIL2PS,
        X86_INS_VPERMILPD,
        X86_INS_VPERMILPS,
        X86_INS_VPERMPD,
        X86_INS_VPERMPS,
        X86_INS_VPERMQ,
        X86_INS_VPERMT2D,
        X86_INS_VPERMT2PD,
        X86_INS_VPERMT2PS,
        X86_INS_VPERMT2Q,
        X86_INS_VPEXPANDD,
        X86_INS_VPEXPANDQ,
        X86_INS_VPEXTRB,
        X86_INS_VPEXTRD,
        X86_INS_VPEXTRQ,
        X86_INS_VPEXTRW,
        X86_INS_VPGATHERDD,
        X86_INS_VPGATHERDQ,
        X86_INS_VPGATHERQD,
        X86_INS_VPGATHERQQ,
        X86_INS_VPHADDBD,
        X86_INS_VPHADDBQ,
        X86_INS_VPHADDBW,
        X86_INS_VPHADDDQ,
        X86_INS_VPHADDD,
        X86_INS_VPHADDSW,
        X86_INS_VPHADDUBD,
        X86_INS_VPHADDUBQ,
        X86_INS_VPHADDUBW,
        X86_INS_VPHADDUDQ,
        X86_INS_VPHADDUWD,
        X86_INS_VPHADDUWQ,
        X86_INS_VPHADDWD,
        X86_INS_VPHADDWQ,
        X86_INS_VPHADDW,
        X86_INS_VPHMINPOSUW,
        X86_INS_VPHSUBBW,
        X86_INS_VPHSUBDQ,
        X86_INS_VPHSUBD,
        X86_INS_VPHSUBSW,
        X86_INS_VPHSUBWD,
        X86_INS_VPHSUBW,
        X86_INS_VPINSRB,
        X86_INS_VPINSRD,
        X86_INS_VPINSRQ,
        X86_INS_VPINSRW,
        X86_INS_VPLZCNTD,
        X86_INS_VPLZCNTQ,
        X86_INS_VPMACSDD,
        X86_INS_VPMACSDQH,
        X86_INS_VPMACSDQL,
        X86_INS_VPMACSSDD,
        X86_INS_VPMACSSDQH,
        X86_INS_VPMACSSDQL,
        X86_INS_VPMACSSWD,
        X86_INS_VPMACSSWW,
        X86_INS_VPMACSWD,
        X86_INS_VPMACSWW,
        X86_INS_VPMADCSSWD,
        X86_INS_VPMADCSWD,
        X86_INS_VPMADDUBSW,
        X86_INS_VPMADDWD,
        X86_INS_VPMASKMOVD,
        X86_INS_VPMASKMOVQ,
        X86_INS_VPMAXSB,
        X86_INS_VPMAXSD,
        X86_INS_VPMAXSQ,
        X86_INS_VPMAXSW,
        X86_INS_VPMAXUB,
        X86_INS_VPMAXUD,
        X86_INS_VPMAXUQ,
        X86_INS_VPMAXUW,
        X86_INS_VPMINSB,
        X86_INS_VPMINSD,
        X86_INS_VPMINSQ,
        X86_INS_VPMINSW,
        X86_INS_VPMINUB,
        X86_INS_VPMINUD,
        X86_INS_VPMINUQ,
        X86_INS_VPMINUW,
        X86_INS_VPMOVDB,
        X86_INS_VPMOVDW,
        X86_INS_VPMOVM2B,
        X86_INS_VPMOVM2D,
        X86_INS_VPMOVM2Q,
        X86_INS_VPMOVM2W,
        X86_INS_VPMOVMSKB,
        X86_INS_VPMOVQB,
        X86_INS_VPMOVQD,
        X86_INS_VPMOVQW,
        X86_INS_VPMOVSDB,
        X86_INS_VPMOVSDW,
        X86_INS_VPMOVSQB,
        X86_INS_VPMOVSQD,
        X86_INS_VPMOVSQW,
        X86_INS_VPMOVSXBD,
        X86_INS_VPMOVSXBQ,
        X86_INS_VPMOVSXBW,
        X86_INS_VPMOVSXDQ,
        X86_INS_VPMOVSXWD,
        X86_INS_VPMOVSXWQ,
        X86_INS_VPMOVUSDB,
        X86_INS_VPMOVUSDW,
        X86_INS_VPMOVUSQB,
        X86_INS_VPMOVUSQD,
        X86_INS_VPMOVUSQW,
        X86_INS_VPMOVZXBD,
        X86_INS_VPMOVZXBQ,
        X86_INS_VPMOVZXBW,
        X86_INS_VPMOVZXDQ,
        X86_INS_VPMOVZXWD,
        X86_INS_VPMOVZXWQ,
        X86_INS_VPMULDQ,
        X86_INS_VPMULHRSW,
        X86_INS_VPMULHUW,
        X86_INS_VPMULHW,
        X86_INS_VPMULLD,
        X86_INS_VPMULLQ,
        X86_INS_VPMULLW,
        X86_INS_VPMULUDQ,
        X86_INS_VPORD,
        X86_INS_VPORQ,
        X86_INS_VPOR,
        X86_INS_VPPERM,
        X86_INS_VPROTB,
        X86_INS_VPROTD,
        X86_INS_VPROTQ,
        X86_INS_VPROTW,
        X86_INS_VPSADBW,
        X86_INS_VPSCATTERDD,
        X86_INS_VPSCATTERDQ,
        X86_INS_VPSCATTERQD,
        X86_INS_VPSCATTERQQ,
        X86_INS_VPSHAB,
        X86_INS_VPSHAD,
        X86_INS_VPSHAQ,
        X86_INS_VPSHAW,
        X86_INS_VPSHLB,
        X86_INS_VPSHLD,
        X86_INS_VPSHLQ,
        X86_INS_VPSHLW,
        X86_INS_VPSHUFB,
        X86_INS_VPSHUFD,
        X86_INS_VPSHUFHW,
        X86_INS_VPSHUFLW,
        X86_INS_VPSIGNB,
        X86_INS_VPSIGND,
        X86_INS_VPSIGNW,
        X86_INS_VPSLLDQ,
        X86_INS_VPSLLD,
        X86_INS_VPSLLQ,
        X86_INS_VPSLLVD,
        X86_INS_VPSLLVQ,
        X86_INS_VPSLLW,
        X86_INS_VPSRAD,
        X86_INS_VPSRAQ,
        X86_INS_VPSRAVD,
        X86_INS_VPSRAVQ,
        X86_INS_VPSRAW,
        X86_INS_VPSRLDQ,
        X86_INS_VPSRLD,
        X86_INS_VPSRLQ,
        X86_INS_VPSRLVD,
        X86_INS_VPSRLVQ,
        X86_INS_VPSRLW,
        X86_INS_VPSUBB,
        X86_INS_VPSUBD,
        X86_INS_VPSUBQ,
        X86_INS_VPSUBSB,
        X86_INS_VPSUBSW,
        X86_INS_VPSUBUSB,
        X86_INS_VPSUBUSW,
        X86_INS_VPSUBW,
        X86_INS_VPTESTMD,
        X86_INS_VPTESTMQ,
        X86_INS_VPTESTNMD,
        X86_INS_VPTESTNMQ,
        X86_INS_VPTEST,
        X86_INS_VPUNPCKHBW,
        X86_INS_VPUNPCKHDQ,
        X86_INS_VPUNPCKHQDQ,
        X86_INS_VPUNPCKHWD,
        X86_INS_VPUNPCKLBW,
        X86_INS_VPUNPCKLDQ,
        X86_INS_VPUNPCKLQDQ,
        X86_INS_VPUNPCKLWD,
        X86_INS_VPXORD,
        X86_INS_VPXORQ,
        X86_INS_VPXOR,
        X86_INS_VRCP14PD,
        X86_INS_VRCP14PS,
        X86_INS_VRCP14SD,
        X86_INS_VRCP14SS,
        X86_INS_VRCP28PD,
        X86_INS_VRCP28PS,
        X86_INS_VRCP28SD,
        X86_INS_VRCP28SS,
        X86_INS_VRCPPS,
        X86_INS_VRCPSS,
        X86_INS_VRNDSCALEPD,
        X86_INS_VRNDSCALEPS,
        X86_INS_VRNDSCALESD,
        X86_INS_VRNDSCALESS,
        X86_INS_VROUNDPD,
        X86_INS_VROUNDPS,
        X86_INS_VROUNDSD,
        X86_INS_VROUNDSS,
        X86_INS_VRSQRT14PD,
        X86_INS_VRSQRT14PS,
        X86_INS_VRSQRT14SD,
        X86_INS_VRSQRT14SS,
        X86_INS_VRSQRT28PD,
        X86_INS_VRSQRT28PS,
        X86_INS_VRSQRT28SD,
        X86_INS_VRSQRT28SS,
        X86_INS_VRSQRTPS,
        X86_INS_VRSQRTSS,
        X86_INS_VSCATTERDPD,
        X86_INS_VSCATTERDPS,
        X86_INS_VSCATTERPF0DPD,
        X86_INS_VSCATTERPF0DPS,
        X86_INS_VSCATTERPF0QPD,
        X86_INS_VSCATTERPF0QPS,
        X86_INS_VSCATTERPF1DPD,
        X86_INS_VSCATTERPF1DPS,
        X86_INS_VSCATTERPF1QPD,
        X86_INS_VSCATTERPF1QPS,
        X86_INS_VSCATTERQPD,
        X86_INS_VSCATTERQPS,
        X86_INS_VSHUFPD,
        X86_INS_VSHUFPS,
        X86_INS_VSQRTPD,
        X86_INS_VSQRTPS,
        X86_INS_VSQRTSD,
        X86_INS_VSQRTSS,
        X86_INS_VSTMXCSR,
        X86_INS_VSUBPD,
        X86_INS_VSUBPS,
        X86_INS_VSUBSD,
        X86_INS_VSUBSS,
        X86_INS_VTESTPD,
        X86_INS_VTESTPS,
        X86_INS_VUNPCKHPD,
        X86_INS_VUNPCKHPS,
        X86_INS_VUNPCKLPD,
        X86_INS_VUNPCKLPS,
        X86_INS_VZEROALL,
        X86_INS_VZEROUPPER,
        X86_INS_WAIT,
        X86_INS_WBINVD,
        X86_INS_WRFSBASE,
        X86_INS_WRGSBASE,
        X86_INS_WRMSR,
        X86_INS_XABORT,
        X86_INS_XACQUIRE,
        X86_INS_XBEGIN,
        X86_INS_XCHG,
        X86_INS_XCRYPTCBC,
        X86_INS_XCRYPTCFB,
        X86_INS_XCRYPTCTR,
        X86_INS_XCRYPTECB,
        X86_INS_XCRYPTOFB,
        X86_INS_XEND,
        X86_INS_XGETBV,
        X86_INS_XLATB,
        X86_INS_XRELEASE,
        X86_INS_XRSTOR,
        X86_INS_XRSTOR64,
        X86_INS_XRSTORS,
        X86_INS_XRSTORS64,
        X86_INS_XSAVE,
        X86_INS_XSAVE64,
        X86_INS_XSAVEC,
        X86_INS_XSAVEC64,
        X86_INS_XSAVEOPT,
        X86_INS_XSAVEOPT64,
        X86_INS_XSAVES,
        X86_INS_XSAVES64,
        X86_INS_XSETBV,
        X86_INS_XSHA1,
        X86_INS_XSHA256,
        X86_INS_XSTORE,
        X86_INS_XTEST,
        X86_INS_FDISI8087_NOP,
        X86_INS_FENI8087_NOP,
        X86_INS_CMPSS,
        X86_INS_CMPEQSS,
        X86_INS_CMPLTSS,
        X86_INS_CMPLESS,
        X86_INS_CMPUNORDSS,
        X86_INS_CMPNEQSS,
        X86_INS_CMPNLTSS,
        X86_INS_CMPNLESS,
        X86_INS_CMPORDSS,
        X86_INS_CMPSD,
        X86_INS_CMPEQSD,
        X86_INS_CMPLTSD,
        X86_INS_CMPLESD,
        X86_INS_CMPUNORDSD,
        X86_INS_CMPNEQSD,
        X86_INS_CMPNLTSD,
        X86_INS_CMPNLESD,
        X86_INS_CMPORDSD,
        X86_INS_CMPPS,
        X86_INS_CMPEQPS,
        X86_INS_CMPLTPS,
        X86_INS_CMPLEPS,
        X86_INS_CMPUNORDPS,
        X86_INS_CMPNEQPS,
        X86_INS_CMPNLTPS,
        X86_INS_CMPNLEPS,
        X86_INS_CMPORDPS,
        X86_INS_CMPPD,
        X86_INS_CMPEQPD,
        X86_INS_CMPLTPD,
        X86_INS_CMPLEPD,
        X86_INS_CMPUNORDPD,
        X86_INS_CMPNEQPD,
        X86_INS_CMPNLTPD,
        X86_INS_CMPNLEPD,
        X86_INS_CMPORDPD,
        X86_INS_VCMPSS,
        X86_INS_VCMPEQSS,
        X86_INS_VCMPLTSS,
        X86_INS_VCMPLESS,
        X86_INS_VCMPUNORDSS,
        X86_INS_VCMPNEQSS,
        X86_INS_VCMPNLTSS,
        X86_INS_VCMPNLESS,
        X86_INS_VCMPORDSS,
        X86_INS_VCMPEQ_UQSS,
        X86_INS_VCMPNGESS,
        X86_INS_VCMPNGTSS,
        X86_INS_VCMPFALSESS,
        X86_INS_VCMPNEQ_OQSS,
        X86_INS_VCMPGESS,
        X86_INS_VCMPGTSS,
        X86_INS_VCMPTRUESS,
        X86_INS_VCMPEQ_OSSS,
        X86_INS_VCMPLT_OQSS,
        X86_INS_VCMPLE_OQSS,
        X86_INS_VCMPUNORD_SSS,
        X86_INS_VCMPNEQ_USSS,
        X86_INS_VCMPNLT_UQSS,
        X86_INS_VCMPNLE_UQSS,
        X86_INS_VCMPORD_SSS,
        X86_INS_VCMPEQ_USSS,
        X86_INS_VCMPNGE_UQSS,
        X86_INS_VCMPNGT_UQSS,
        X86_INS_VCMPFALSE_OSSS,
        X86_INS_VCMPNEQ_OSSS,
        X86_INS_VCMPGE_OQSS,
        X86_INS_VCMPGT_OQSS,
        X86_INS_VCMPTRUE_USSS,
        X86_INS_VCMPSD,
        X86_INS_VCMPEQSD,
        X86_INS_VCMPLTSD,
        X86_INS_VCMPLESD,
        X86_INS_VCMPUNORDSD,
        X86_INS_VCMPNEQSD,
        X86_INS_VCMPNLTSD,
        X86_INS_VCMPNLESD,
        X86_INS_VCMPORDSD,
        X86_INS_VCMPEQ_UQSD,
        X86_INS_VCMPNGESD,
        X86_INS_VCMPNGTSD,
        X86_INS_VCMPFALSESD,
        X86_INS_VCMPNEQ_OQSD,
        X86_INS_VCMPGESD,
        X86_INS_VCMPGTSD,
        X86_INS_VCMPTRUESD,
        X86_INS_VCMPEQ_OSSD,
        X86_INS_VCMPLT_OQSD,
        X86_INS_VCMPLE_OQSD,
        X86_INS_VCMPUNORD_SSD,
        X86_INS_VCMPNEQ_USSD,
        X86_INS_VCMPNLT_UQSD,
        X86_INS_VCMPNLE_UQSD,
        X86_INS_VCMPORD_SSD,
        X86_INS_VCMPEQ_USSD,
        X86_INS_VCMPNGE_UQSD,
        X86_INS_VCMPNGT_UQSD,
        X86_INS_VCMPFALSE_OSSD,
        X86_INS_VCMPNEQ_OSSD,
        X86_INS_VCMPGE_OQSD,
        X86_INS_VCMPGT_OQSD,
        X86_INS_VCMPTRUE_USSD,
        X86_INS_VCMPPS,
        X86_INS_VCMPEQPS,
        X86_INS_VCMPLTPS,
        X86_INS_VCMPLEPS,
        X86_INS_VCMPUNORDPS,
        X86_INS_VCMPNEQPS,
        X86_INS_VCMPNLTPS,
        X86_INS_VCMPNLEPS,
        X86_INS_VCMPORDPS,
        X86_INS_VCMPEQ_UQPS,
        X86_INS_VCMPNGEPS,
        X86_INS_VCMPNGTPS,
        X86_INS_VCMPFALSEPS,
        X86_INS_VCMPNEQ_OQPS,
        X86_INS_VCMPGEPS,
        X86_INS_VCMPGTPS,
        X86_INS_VCMPTRUEPS,
        X86_INS_VCMPEQ_OSPS,
        X86_INS_VCMPLT_OQPS,
        X86_INS_VCMPLE_OQPS,
        X86_INS_VCMPUNORD_SPS,
        X86_INS_VCMPNEQ_USPS,
        X86_INS_VCMPNLT_UQPS,
        X86_INS_VCMPNLE_UQPS,
        X86_INS_VCMPORD_SPS,
        X86_INS_VCMPEQ_USPS,
        X86_INS_VCMPNGE_UQPS,
        X86_INS_VCMPNGT_UQPS,
        X86_INS_VCMPFALSE_OSPS,
        X86_INS_VCMPNEQ_OSPS,
        X86_INS_VCMPGE_OQPS,
        X86_INS_VCMPGT_OQPS,
        X86_INS_VCMPTRUE_USPS,
        X86_INS_VCMPPD,
        X86_INS_VCMPEQPD,
        X86_INS_VCMPLTPD,
        X86_INS_VCMPLEPD,
        X86_INS_VCMPUNORDPD,
        X86_INS_VCMPNEQPD,
        X86_INS_VCMPNLTPD,
        X86_INS_VCMPNLEPD,
        X86_INS_VCMPORDPD,
        X86_INS_VCMPEQ_UQPD,
        X86_INS_VCMPNGEPD,
        X86_INS_VCMPNGTPD,
        X86_INS_VCMPFALSEPD,
        X86_INS_VCMPNEQ_OQPD,
        X86_INS_VCMPGEPD,
        X86_INS_VCMPGTPD,
        X86_INS_VCMPTRUEPD,
        X86_INS_VCMPEQ_OSPD,
        X86_INS_VCMPLT_OQPD,
        X86_INS_VCMPLE_OQPD,
        X86_INS_VCMPUNORD_SPD,
        X86_INS_VCMPNEQ_USPD,
        X86_INS_VCMPNLT_UQPD,
        X86_INS_VCMPNLE_UQPD,
        X86_INS_VCMPORD_SPD,
        X86_INS_VCMPEQ_USPD,
        X86_INS_VCMPNGE_UQPD,
        X86_INS_VCMPNGT_UQPD,
        X86_INS_VCMPFALSE_OSPD,
        X86_INS_VCMPNEQ_OSPD,
        X86_INS_VCMPGE_OQPD,
        X86_INS_VCMPGT_OQPD,
        X86_INS_VCMPTRUE_USPD,
        X86_INS_UD0,
        X86_INS_ENDBR32,
        X86_INS_ENDBR64
    }
}