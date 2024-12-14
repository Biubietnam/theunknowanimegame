using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200102F RID: 4143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueVirtualItemInfo : IMessage<RogueVirtualItemInfo>, IMessage, IEquatable<RogueVirtualItemInfo>, IDeepCloneable<RogueVirtualItemInfo>, IBufferMessage
	{
		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600B82E RID: 47150 RVA: 0x001EE2E5 File Offset: 0x001EC4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueVirtualItemInfo> Parser
		{
			get
			{
				return RogueVirtualItemInfo._parser;
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600B82F RID: 47151 RVA: 0x001EE2EC File Offset: 0x001EC4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueVirtualItemInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x001EE2FE File Offset: 0x001EC4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueVirtualItemInfo.Descriptor;
			}
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x001EE305 File Offset: 0x001EC505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItemInfo()
		{
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x001EE310 File Offset: 0x001EC510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItemInfo(RogueVirtualItemInfo other) : this()
		{
			this.eIGBNLJBCGO_ = other.eIGBNLJBCGO_;
			this.eOHLIDIKJJN_ = other.eOHLIDIKJJN_;
			this.pNOKGLMGPEC_ = other.pNOKGLMGPEC_;
			this.bLLJIGPHNOL_ = other.bLLJIGPHNOL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x001EE364 File Offset: 0x001EC564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItemInfo Clone()
		{
			return new RogueVirtualItemInfo(this);
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600B834 RID: 47156 RVA: 0x001EE36C File Offset: 0x001EC56C
		// (set) Token: 0x0600B835 RID: 47157 RVA: 0x001EE374 File Offset: 0x001EC574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EIGBNLJBCGO
		{
			get
			{
				return this.eIGBNLJBCGO_;
			}
			set
			{
				this.eIGBNLJBCGO_ = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600B836 RID: 47158 RVA: 0x001EE37D File Offset: 0x001EC57D
		// (set) Token: 0x0600B837 RID: 47159 RVA: 0x001EE385 File Offset: 0x001EC585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EOHLIDIKJJN
		{
			get
			{
				return this.eOHLIDIKJJN_;
			}
			set
			{
				this.eOHLIDIKJJN_ = value;
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600B838 RID: 47160 RVA: 0x001EE38E File Offset: 0x001EC58E
		// (set) Token: 0x0600B839 RID: 47161 RVA: 0x001EE396 File Offset: 0x001EC596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PNOKGLMGPEC
		{
			get
			{
				return this.pNOKGLMGPEC_;
			}
			set
			{
				this.pNOKGLMGPEC_ = value;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600B83A RID: 47162 RVA: 0x001EE39F File Offset: 0x001EC59F
		// (set) Token: 0x0600B83B RID: 47163 RVA: 0x001EE3A7 File Offset: 0x001EC5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BLLJIGPHNOL
		{
			get
			{
				return this.bLLJIGPHNOL_;
			}
			set
			{
				this.bLLJIGPHNOL_ = value;
			}
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x001EE3B0 File Offset: 0x001EC5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueVirtualItemInfo);
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x001EE3C0 File Offset: 0x001EC5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueVirtualItemInfo other)
		{
			return other != null && (other == this || (this.EIGBNLJBCGO == other.EIGBNLJBCGO && this.EOHLIDIKJJN == other.EOHLIDIKJJN && this.PNOKGLMGPEC == other.PNOKGLMGPEC && this.BLLJIGPHNOL == other.BLLJIGPHNOL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x001EE42C File Offset: 0x001EC62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EIGBNLJBCGO != 0U)
			{
				num ^= this.EIGBNLJBCGO.GetHashCode();
			}
			if (this.EOHLIDIKJJN != 0U)
			{
				num ^= this.EOHLIDIKJJN.GetHashCode();
			}
			if (this.PNOKGLMGPEC != 0U)
			{
				num ^= this.PNOKGLMGPEC.GetHashCode();
			}
			if (this.BLLJIGPHNOL != 0U)
			{
				num ^= this.BLLJIGPHNOL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B83F RID: 47167 RVA: 0x001EE4B6 File Offset: 0x001EC6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x001EE4BE File Offset: 0x001EC6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x001EE4C8 File Offset: 0x001EC6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EOHLIDIKJJN != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EOHLIDIKJJN);
			}
			if (this.PNOKGLMGPEC != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PNOKGLMGPEC);
			}
			if (this.EIGBNLJBCGO != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.EIGBNLJBCGO);
			}
			if (this.BLLJIGPHNOL != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BLLJIGPHNOL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x001EE55C File Offset: 0x001EC75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EIGBNLJBCGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EIGBNLJBCGO);
			}
			if (this.EOHLIDIKJJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EOHLIDIKJJN);
			}
			if (this.PNOKGLMGPEC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PNOKGLMGPEC);
			}
			if (this.BLLJIGPHNOL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BLLJIGPHNOL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B843 RID: 47171 RVA: 0x001EE5E4 File Offset: 0x001EC7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueVirtualItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EIGBNLJBCGO != 0U)
			{
				this.EIGBNLJBCGO = other.EIGBNLJBCGO;
			}
			if (other.EOHLIDIKJJN != 0U)
			{
				this.EOHLIDIKJJN = other.EOHLIDIKJJN;
			}
			if (other.PNOKGLMGPEC != 0U)
			{
				this.PNOKGLMGPEC = other.PNOKGLMGPEC;
			}
			if (other.BLLJIGPHNOL != 0U)
			{
				this.BLLJIGPHNOL = other.BLLJIGPHNOL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x001EE65C File Offset: 0x001EC85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B845 RID: 47173 RVA: 0x001EE668 File Offset: 0x001EC868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.EOHLIDIKJJN = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PNOKGLMGPEC = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EIGBNLJBCGO = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.BLLJIGPHNOL = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A9F RID: 19103
		private static readonly MessageParser<RogueVirtualItemInfo> _parser = new MessageParser<RogueVirtualItemInfo>(() => new RogueVirtualItemInfo());

		// Token: 0x04004AA0 RID: 19104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AA1 RID: 19105
		public const int EIGBNLJBCGOFieldNumber = 10;

		// Token: 0x04004AA2 RID: 19106
		private uint eIGBNLJBCGO_;

		// Token: 0x04004AA3 RID: 19107
		public const int EOHLIDIKJJNFieldNumber = 6;

		// Token: 0x04004AA4 RID: 19108
		private uint eOHLIDIKJJN_;

		// Token: 0x04004AA5 RID: 19109
		public const int PNOKGLMGPECFieldNumber = 7;

		// Token: 0x04004AA6 RID: 19110
		private uint pNOKGLMGPEC_;

		// Token: 0x04004AA7 RID: 19111
		public const int BLLJIGPHNOLFieldNumber = 11;

		// Token: 0x04004AA8 RID: 19112
		private uint bLLJIGPHNOL_;
	}
}
