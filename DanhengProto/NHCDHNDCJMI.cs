using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C1B RID: 3099
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NHCDHNDCJMI : IMessage<NHCDHNDCJMI>, IMessage, IEquatable<NHCDHNDCJMI>, IDeepCloneable<NHCDHNDCJMI>, IBufferMessage
	{
		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x0600894A RID: 35146 RVA: 0x0016AAC0 File Offset: 0x00168CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NHCDHNDCJMI> Parser
		{
			get
			{
				return NHCDHNDCJMI._parser;
			}
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600894B RID: 35147 RVA: 0x0016AAC7 File Offset: 0x00168CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NHCDHNDCJMIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x0016AAD9 File Offset: 0x00168CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NHCDHNDCJMI.Descriptor;
			}
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x0016AAE0 File Offset: 0x00168CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHCDHNDCJMI()
		{
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x0016AAE8 File Offset: 0x00168CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHCDHNDCJMI(NHCDHNDCJMI other) : this()
		{
			this.iCKOBLBOKIH_ = other.iCKOBLBOKIH_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x0016AB19 File Offset: 0x00168D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NHCDHNDCJMI Clone()
		{
			return new NHCDHNDCJMI(this);
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x06008950 RID: 35152 RVA: 0x0016AB21 File Offset: 0x00168D21
		// (set) Token: 0x06008951 RID: 35153 RVA: 0x0016AB29 File Offset: 0x00168D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ICKOBLBOKIH
		{
			get
			{
				return this.iCKOBLBOKIH_;
			}
			set
			{
				this.iCKOBLBOKIH_ = value;
			}
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x06008952 RID: 35154 RVA: 0x0016AB32 File Offset: 0x00168D32
		// (set) Token: 0x06008953 RID: 35155 RVA: 0x0016AB3A File Offset: 0x00168D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x0016AB43 File Offset: 0x00168D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NHCDHNDCJMI);
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x0016AB51 File Offset: 0x00168D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NHCDHNDCJMI other)
		{
			return other != null && (other == this || (this.ICKOBLBOKIH == other.ICKOBLBOKIH && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x0016AB90 File Offset: 0x00168D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ICKOBLBOKIH != 0U)
			{
				num ^= this.ICKOBLBOKIH.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x0016ABE8 File Offset: 0x00168DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x0016ABF0 File Offset: 0x00168DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008959 RID: 35161 RVA: 0x0016ABFC File Offset: 0x00168DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Level);
			}
			if (this.ICKOBLBOKIH != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ICKOBLBOKIH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x0016AC58 File Offset: 0x00168E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ICKOBLBOKIH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICKOBLBOKIH);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x0016ACB0 File Offset: 0x00168EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NHCDHNDCJMI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ICKOBLBOKIH != 0U)
			{
				this.ICKOBLBOKIH = other.ICKOBLBOKIH;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x0016AD00 File Offset: 0x00168F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x0016AD0C File Offset: 0x00168F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ICKOBLBOKIH = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040034AA RID: 13482
		private static readonly MessageParser<NHCDHNDCJMI> _parser = new MessageParser<NHCDHNDCJMI>(() => new NHCDHNDCJMI());

		// Token: 0x040034AB RID: 13483
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034AC RID: 13484
		public const int ICKOBLBOKIHFieldNumber = 14;

		// Token: 0x040034AD RID: 13485
		private uint iCKOBLBOKIH_;

		// Token: 0x040034AE RID: 13486
		public const int LevelFieldNumber = 4;

		// Token: 0x040034AF RID: 13487
		private uint level_;
	}
}
