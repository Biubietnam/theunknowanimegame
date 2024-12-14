using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000067 RID: 103
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideSpiritInfoScNotify : IMessage<AetherDivideSpiritInfoScNotify>, IMessage, IEquatable<AetherDivideSpiritInfoScNotify>, IDeepCloneable<AetherDivideSpiritInfoScNotify>, IBufferMessage
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0000D027 File Offset: 0x0000B227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideSpiritInfoScNotify> Parser
		{
			get
			{
				return AetherDivideSpiritInfoScNotify._parser;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000D02E File Offset: 0x0000B22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideSpiritInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0000D040 File Offset: 0x0000B240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideSpiritInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000D047 File Offset: 0x0000B247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfoScNotify()
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000D05C File Offset: 0x0000B25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfoScNotify(AetherDivideSpiritInfoScNotify other) : this()
		{
			this.nPGOMLFGBJM_ = other.nPGOMLFGBJM_;
			this.bHNEEKNMICA_ = other.bHNEEKNMICA_.Clone();
			this.aetherInfo_ = ((other.aetherInfo_ != null) ? other.aetherInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000D0B9 File Offset: 0x0000B2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfoScNotify Clone()
		{
			return new AetherDivideSpiritInfoScNotify(this);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0000D0C9 File Offset: 0x0000B2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NPGOMLFGBJM
		{
			get
			{
				return this.nPGOMLFGBJM_;
			}
			set
			{
				this.nPGOMLFGBJM_ = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000D0D2 File Offset: 0x0000B2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AetherDivideSpiritInfo> BHNEEKNMICA
		{
			get
			{
				return this.bHNEEKNMICA_;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000D0DA File Offset: 0x0000B2DA
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0000D0E2 File Offset: 0x0000B2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfo AetherInfo
		{
			get
			{
				return this.aetherInfo_;
			}
			set
			{
				this.aetherInfo_ = value;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000D0EB File Offset: 0x0000B2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideSpiritInfoScNotify);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideSpiritInfoScNotify other)
		{
			return other != null && (other == this || (this.NPGOMLFGBJM == other.NPGOMLFGBJM && this.bHNEEKNMICA_.Equals(other.bHNEEKNMICA_) && object.Equals(this.AetherInfo, other.AetherInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000D160 File Offset: 0x0000B360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NPGOMLFGBJM != 0U)
			{
				num ^= this.NPGOMLFGBJM.GetHashCode();
			}
			num ^= this.bHNEEKNMICA_.GetHashCode();
			if (this.aetherInfo_ != null)
			{
				num ^= this.AetherInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000D1CB File Offset: 0x0000B3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bHNEEKNMICA_.WriteTo(ref output, AetherDivideSpiritInfoScNotify._repeated_bHNEEKNMICA_codec);
			if (this.aetherInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AetherInfo);
			}
			if (this.NPGOMLFGBJM != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NPGOMLFGBJM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000D240 File Offset: 0x0000B440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NPGOMLFGBJM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NPGOMLFGBJM);
			}
			num += this.bHNEEKNMICA_.CalculateSize(AetherDivideSpiritInfoScNotify._repeated_bHNEEKNMICA_codec);
			if (this.aetherInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AetherInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000D2AC File Offset: 0x0000B4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideSpiritInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NPGOMLFGBJM != 0U)
			{
				this.NPGOMLFGBJM = other.NPGOMLFGBJM;
			}
			this.bHNEEKNMICA_.Add(other.bHNEEKNMICA_);
			if (other.aetherInfo_ != null)
			{
				if (this.aetherInfo_ == null)
				{
					this.AetherInfo = new AetherDivideSpiritInfo();
				}
				this.AetherInfo.MergeFrom(other.AetherInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000D325 File Offset: 0x0000B525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000D330 File Offset: 0x0000B530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 26U)
					{
						if (num != 48U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NPGOMLFGBJM = input.ReadUInt32();
						}
					}
					else
					{
						if (this.aetherInfo_ == null)
						{
							this.AetherInfo = new AetherDivideSpiritInfo();
						}
						input.ReadMessage(this.AetherInfo);
					}
				}
				else
				{
					this.bHNEEKNMICA_.AddEntriesFrom(ref input, AetherDivideSpiritInfoScNotify._repeated_bHNEEKNMICA_codec);
				}
			}
		}

		// Token: 0x0400019C RID: 412
		private static readonly MessageParser<AetherDivideSpiritInfoScNotify> _parser = new MessageParser<AetherDivideSpiritInfoScNotify>(() => new AetherDivideSpiritInfoScNotify());

		// Token: 0x0400019D RID: 413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400019E RID: 414
		public const int NPGOMLFGBJMFieldNumber = 6;

		// Token: 0x0400019F RID: 415
		private uint nPGOMLFGBJM_;

		// Token: 0x040001A0 RID: 416
		public const int BHNEEKNMICAFieldNumber = 1;

		// Token: 0x040001A1 RID: 417
		private static readonly FieldCodec<AetherDivideSpiritInfo> _repeated_bHNEEKNMICA_codec = FieldCodec.ForMessage<AetherDivideSpiritInfo>(10U, AetherDivideSpiritInfo.Parser);

		// Token: 0x040001A2 RID: 418
		private readonly RepeatedField<AetherDivideSpiritInfo> bHNEEKNMICA_ = new RepeatedField<AetherDivideSpiritInfo>();

		// Token: 0x040001A3 RID: 419
		public const int AetherInfoFieldNumber = 3;

		// Token: 0x040001A4 RID: 420
		private AetherDivideSpiritInfo aetherInfo_;
	}
}
