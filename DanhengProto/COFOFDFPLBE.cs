using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200030F RID: 783
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class COFOFDFPLBE : IMessage<COFOFDFPLBE>, IMessage, IEquatable<COFOFDFPLBE>, IDeepCloneable<COFOFDFPLBE>, IBufferMessage
	{
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x00063CA8 File Offset: 0x00061EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<COFOFDFPLBE> Parser
		{
			get
			{
				return COFOFDFPLBE._parser;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00063CAF File Offset: 0x00061EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return COFOFDFPLBEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x00063CC1 File Offset: 0x00061EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return COFOFDFPLBE.Descriptor;
			}
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00063CC8 File Offset: 0x00061EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COFOFDFPLBE()
		{
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00063CD0 File Offset: 0x00061ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COFOFDFPLBE(COFOFDFPLBE other) : this()
		{
			this.aCBDLOOPBMH_ = other.aCBDLOOPBMH_;
			this.pLFPJDMGBBN_ = other.pLFPJDMGBBN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00063D01 File Offset: 0x00061F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COFOFDFPLBE Clone()
		{
			return new COFOFDFPLBE(this);
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x00063D09 File Offset: 0x00061F09
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x00063D11 File Offset: 0x00061F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACBDLOOPBMH
		{
			get
			{
				return this.aCBDLOOPBMH_;
			}
			set
			{
				this.aCBDLOOPBMH_ = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00063D1A File Offset: 0x00061F1A
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x00063D22 File Offset: 0x00061F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PLFPJDMGBBN
		{
			get
			{
				return this.pLFPJDMGBBN_;
			}
			set
			{
				this.pLFPJDMGBBN_ = value;
			}
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00063D2B File Offset: 0x00061F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as COFOFDFPLBE);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00063D39 File Offset: 0x00061F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(COFOFDFPLBE other)
		{
			return other != null && (other == this || (this.ACBDLOOPBMH == other.ACBDLOOPBMH && this.PLFPJDMGBBN == other.PLFPJDMGBBN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00063D78 File Offset: 0x00061F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ACBDLOOPBMH != 0U)
			{
				num ^= this.ACBDLOOPBMH.GetHashCode();
			}
			if (this.PLFPJDMGBBN)
			{
				num ^= this.PLFPJDMGBBN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00063DD0 File Offset: 0x00061FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00063DD8 File Offset: 0x00061FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00063DE4 File Offset: 0x00061FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PLFPJDMGBBN)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.PLFPJDMGBBN);
			}
			if (this.ACBDLOOPBMH != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.ACBDLOOPBMH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00063E40 File Offset: 0x00062040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ACBDLOOPBMH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACBDLOOPBMH);
			}
			if (this.PLFPJDMGBBN)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00063E8C File Offset: 0x0006208C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(COFOFDFPLBE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ACBDLOOPBMH != 0U)
			{
				this.ACBDLOOPBMH = other.ACBDLOOPBMH;
			}
			if (other.PLFPJDMGBBN)
			{
				this.PLFPJDMGBBN = other.PLFPJDMGBBN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00063EDC File Offset: 0x000620DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00063EE8 File Offset: 0x000620E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ACBDLOOPBMH = input.ReadUInt32();
					}
				}
				else
				{
					this.PLFPJDMGBBN = input.ReadBool();
				}
			}
		}

		// Token: 0x04000E72 RID: 3698
		private static readonly MessageParser<COFOFDFPLBE> _parser = new MessageParser<COFOFDFPLBE>(() => new COFOFDFPLBE());

		// Token: 0x04000E73 RID: 3699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E74 RID: 3700
		public const int ACBDLOOPBMHFieldNumber = 11;

		// Token: 0x04000E75 RID: 3701
		private uint aCBDLOOPBMH_;

		// Token: 0x04000E76 RID: 3702
		public const int PLFPJDMGBBNFieldNumber = 5;

		// Token: 0x04000E77 RID: 3703
		private bool pLFPJDMGBBN_;
	}
}
