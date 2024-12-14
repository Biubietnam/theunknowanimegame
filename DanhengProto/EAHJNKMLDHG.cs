using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003EB RID: 1003
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EAHJNKMLDHG : IMessage<EAHJNKMLDHG>, IMessage, IEquatable<EAHJNKMLDHG>, IDeepCloneable<EAHJNKMLDHG>, IBufferMessage
	{
		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x0007BD10 File Offset: 0x00079F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EAHJNKMLDHG> Parser
		{
			get
			{
				return EAHJNKMLDHG._parser;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x0007BD17 File Offset: 0x00079F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EAHJNKMLDHGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x0007BD29 File Offset: 0x00079F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EAHJNKMLDHG.Descriptor;
			}
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x0007BD30 File Offset: 0x00079F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EAHJNKMLDHG()
		{
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x0007BD38 File Offset: 0x00079F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EAHJNKMLDHG(EAHJNKMLDHG other) : this()
		{
			this.gAJNFOGLJGE_ = other.gAJNFOGLJGE_;
			this.buffId_ = other.buffId_;
			this.bBELNBDLEGG_ = other.bBELNBDLEGG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0007BD75 File Offset: 0x00079F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EAHJNKMLDHG Clone()
		{
			return new EAHJNKMLDHG(this);
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x0007BD7D File Offset: 0x00079F7D
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x0007BD85 File Offset: 0x00079F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GAJNFOGLJGE
		{
			get
			{
				return this.gAJNFOGLJGE_;
			}
			set
			{
				this.gAJNFOGLJGE_ = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x0007BD8E File Offset: 0x00079F8E
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x0007BD96 File Offset: 0x00079F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x0007BD9F File Offset: 0x00079F9F
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x0007BDA7 File Offset: 0x00079FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BBELNBDLEGG
		{
			get
			{
				return this.bBELNBDLEGG_;
			}
			set
			{
				this.bBELNBDLEGG_ = value;
			}
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0007BDB0 File Offset: 0x00079FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EAHJNKMLDHG);
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0007BDC0 File Offset: 0x00079FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EAHJNKMLDHG other)
		{
			return other != null && (other == this || (this.GAJNFOGLJGE == other.GAJNFOGLJGE && this.BuffId == other.BuffId && this.BBELNBDLEGG == other.BBELNBDLEGG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0007BE1C File Offset: 0x0007A01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GAJNFOGLJGE != 0U)
			{
				num ^= this.GAJNFOGLJGE.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.BBELNBDLEGG != 0U)
			{
				num ^= this.BBELNBDLEGG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0007BE8D File Offset: 0x0007A08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0007BE95 File Offset: 0x0007A095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0007BEA0 File Offset: 0x0007A0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BuffId);
			}
			if (this.BBELNBDLEGG != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BBELNBDLEGG);
			}
			if (this.GAJNFOGLJGE != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GAJNFOGLJGE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0007BF14 File Offset: 0x0007A114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GAJNFOGLJGE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GAJNFOGLJGE);
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this.BBELNBDLEGG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBELNBDLEGG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x0007BF84 File Offset: 0x0007A184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EAHJNKMLDHG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GAJNFOGLJGE != 0U)
			{
				this.GAJNFOGLJGE = other.GAJNFOGLJGE;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			if (other.BBELNBDLEGG != 0U)
			{
				this.BBELNBDLEGG = other.BBELNBDLEGG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0007BFF4 File Offset: 0x0007A1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GAJNFOGLJGE = input.ReadUInt32();
						}
					}
					else
					{
						this.BBELNBDLEGG = input.ReadUInt32();
					}
				}
				else
				{
					this.BuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001204 RID: 4612
		private static readonly MessageParser<EAHJNKMLDHG> _parser = new MessageParser<EAHJNKMLDHG>(() => new EAHJNKMLDHG());

		// Token: 0x04001205 RID: 4613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001206 RID: 4614
		public const int GAJNFOGLJGEFieldNumber = 11;

		// Token: 0x04001207 RID: 4615
		private uint gAJNFOGLJGE_;

		// Token: 0x04001208 RID: 4616
		public const int BuffIdFieldNumber = 1;

		// Token: 0x04001209 RID: 4617
		private uint buffId_;

		// Token: 0x0400120A RID: 4618
		public const int BBELNBDLEGGFieldNumber = 2;

		// Token: 0x0400120B RID: 4619
		private uint bBELNBDLEGG_;
	}
}
