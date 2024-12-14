using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001353 RID: 4947
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextJoinInfo : IMessage<TextJoinInfo>, IMessage, IEquatable<TextJoinInfo>, IDeepCloneable<TextJoinInfo>, IBufferMessage
	{
		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x0024BC7B File Offset: 0x00249E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TextJoinInfo> Parser
		{
			get
			{
				return TextJoinInfo._parser;
			}
		}

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x0600DCC7 RID: 56519 RVA: 0x0024BC82 File Offset: 0x00249E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TextJoinInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x0600DCC8 RID: 56520 RVA: 0x0024BC94 File Offset: 0x00249E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextJoinInfo.Descriptor;
			}
		}

		// Token: 0x0600DCC9 RID: 56521 RVA: 0x0024BC9B File Offset: 0x00249E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinInfo()
		{
		}

		// Token: 0x0600DCCA RID: 56522 RVA: 0x0024BCBC File Offset: 0x00249EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinInfo(TextJoinInfo other) : this()
		{
			this.dLCKGEKDBON_ = other.dLCKGEKDBON_;
			this.aINAOENMOME_ = other.aINAOENMOME_;
			this.textJoinItemId_ = other.textJoinItemId_;
			this.textItemConfigId_ = other.textItemConfigId_;
			this.textItemId_ = other.textItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCCB RID: 56523 RVA: 0x0024BD1C File Offset: 0x00249F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinInfo Clone()
		{
			return new TextJoinInfo(this);
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x0600DCCC RID: 56524 RVA: 0x0024BD24 File Offset: 0x00249F24
		// (set) Token: 0x0600DCCD RID: 56525 RVA: 0x0024BD2C File Offset: 0x00249F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DLCKGEKDBON
		{
			get
			{
				return this.dLCKGEKDBON_;
			}
			set
			{
				this.dLCKGEKDBON_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x0600DCCE RID: 56526 RVA: 0x0024BD3F File Offset: 0x00249F3F
		// (set) Token: 0x0600DCCF RID: 56527 RVA: 0x0024BD47 File Offset: 0x00249F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AINAOENMOME
		{
			get
			{
				return this.aINAOENMOME_;
			}
			set
			{
				this.aINAOENMOME_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x0600DCD0 RID: 56528 RVA: 0x0024BD5A File Offset: 0x00249F5A
		// (set) Token: 0x0600DCD1 RID: 56529 RVA: 0x0024BD62 File Offset: 0x00249F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextJoinItemId
		{
			get
			{
				return this.textJoinItemId_;
			}
			set
			{
				this.textJoinItemId_ = value;
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x0600DCD2 RID: 56530 RVA: 0x0024BD6B File Offset: 0x00249F6B
		// (set) Token: 0x0600DCD3 RID: 56531 RVA: 0x0024BD73 File Offset: 0x00249F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextItemConfigId
		{
			get
			{
				return this.textItemConfigId_;
			}
			set
			{
				this.textItemConfigId_ = value;
			}
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x0600DCD4 RID: 56532 RVA: 0x0024BD7C File Offset: 0x00249F7C
		// (set) Token: 0x0600DCD5 RID: 56533 RVA: 0x0024BD84 File Offset: 0x00249F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextItemId
		{
			get
			{
				return this.textItemId_;
			}
			set
			{
				this.textItemId_ = value;
			}
		}

		// Token: 0x0600DCD6 RID: 56534 RVA: 0x0024BD8D File Offset: 0x00249F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextJoinInfo);
		}

		// Token: 0x0600DCD7 RID: 56535 RVA: 0x0024BD9C File Offset: 0x00249F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TextJoinInfo other)
		{
			return other != null && (other == this || (!(this.DLCKGEKDBON != other.DLCKGEKDBON) && !(this.AINAOENMOME != other.AINAOENMOME) && this.TextJoinItemId == other.TextJoinItemId && this.TextItemConfigId == other.TextItemConfigId && this.TextItemId == other.TextItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCD8 RID: 56536 RVA: 0x0024BE20 File Offset: 0x0024A020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DLCKGEKDBON.Length != 0)
			{
				num ^= this.DLCKGEKDBON.GetHashCode();
			}
			if (this.AINAOENMOME.Length != 0)
			{
				num ^= this.AINAOENMOME.GetHashCode();
			}
			if (this.TextJoinItemId != 0U)
			{
				num ^= this.TextJoinItemId.GetHashCode();
			}
			if (this.TextItemConfigId != 0U)
			{
				num ^= this.TextItemConfigId.GetHashCode();
			}
			if (this.TextItemId != 0U)
			{
				num ^= this.TextItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCD9 RID: 56537 RVA: 0x0024BEC7 File Offset: 0x0024A0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DCDA RID: 56538 RVA: 0x0024BECF File Offset: 0x0024A0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCDB RID: 56539 RVA: 0x0024BED8 File Offset: 0x0024A0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TextJoinItemId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TextJoinItemId);
			}
			if (this.DLCKGEKDBON.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.DLCKGEKDBON);
			}
			if (this.TextItemConfigId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.TextItemConfigId);
			}
			if (this.TextItemId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.TextItemId);
			}
			if (this.AINAOENMOME.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.AINAOENMOME);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCDC RID: 56540 RVA: 0x0024BF90 File Offset: 0x0024A190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DLCKGEKDBON.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DLCKGEKDBON);
			}
			if (this.AINAOENMOME.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AINAOENMOME);
			}
			if (this.TextJoinItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextJoinItemId);
			}
			if (this.TextItemConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextItemConfigId);
			}
			if (this.TextItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCDD RID: 56541 RVA: 0x0024C038 File Offset: 0x0024A238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TextJoinInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DLCKGEKDBON.Length != 0)
			{
				this.DLCKGEKDBON = other.DLCKGEKDBON;
			}
			if (other.AINAOENMOME.Length != 0)
			{
				this.AINAOENMOME = other.AINAOENMOME;
			}
			if (other.TextJoinItemId != 0U)
			{
				this.TextJoinItemId = other.TextJoinItemId;
			}
			if (other.TextItemConfigId != 0U)
			{
				this.TextItemConfigId = other.TextItemConfigId;
			}
			if (other.TextItemId != 0U)
			{
				this.TextItemId = other.TextItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCDE RID: 56542 RVA: 0x0024C0CE File Offset: 0x0024A2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCDF RID: 56543 RVA: 0x0024C0D8 File Offset: 0x0024A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 16U)
					{
						this.TextJoinItemId = input.ReadUInt32();
						continue;
					}
					if (num == 82U)
					{
						this.DLCKGEKDBON = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.TextItemConfigId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.TextItemId = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						this.AINAOENMOME = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057D0 RID: 22480
		private static readonly MessageParser<TextJoinInfo> _parser = new MessageParser<TextJoinInfo>(() => new TextJoinInfo());

		// Token: 0x040057D1 RID: 22481
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057D2 RID: 22482
		public const int DLCKGEKDBONFieldNumber = 10;

		// Token: 0x040057D3 RID: 22483
		private string dLCKGEKDBON_ = "";

		// Token: 0x040057D4 RID: 22484
		public const int AINAOENMOMEFieldNumber = 14;

		// Token: 0x040057D5 RID: 22485
		private string aINAOENMOME_ = "";

		// Token: 0x040057D6 RID: 22486
		public const int TextJoinItemIdFieldNumber = 2;

		// Token: 0x040057D7 RID: 22487
		private uint textJoinItemId_;

		// Token: 0x040057D8 RID: 22488
		public const int TextItemConfigIdFieldNumber = 11;

		// Token: 0x040057D9 RID: 22489
		private uint textItemConfigId_;

		// Token: 0x040057DA RID: 22490
		public const int TextItemIdFieldNumber = 12;

		// Token: 0x040057DB RID: 22491
		private uint textItemId_;
	}
}
