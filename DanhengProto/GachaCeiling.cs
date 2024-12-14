using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005CD RID: 1485
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GachaCeiling : IMessage<GachaCeiling>, IMessage, IEquatable<GachaCeiling>, IDeepCloneable<GachaCeiling>, IBufferMessage
	{
		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x000B4593 File Offset: 0x000B2793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaCeiling> Parser
		{
			get
			{
				return GachaCeiling._parser;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x000B459A File Offset: 0x000B279A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GachaCeilingReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x000B45AC File Offset: 0x000B27AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaCeiling.Descriptor;
			}
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x000B45B3 File Offset: 0x000B27B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeiling()
		{
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x000B45C8 File Offset: 0x000B27C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeiling(GachaCeiling other) : this()
		{
			this.isClaimed_ = other.isClaimed_;
			this.ceilingNum_ = other.ceilingNum_;
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x000B4615 File Offset: 0x000B2815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeiling Clone()
		{
			return new GachaCeiling(this);
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x000B461D File Offset: 0x000B281D
		// (set) Token: 0x06004245 RID: 16965 RVA: 0x000B4625 File Offset: 0x000B2825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsClaimed
		{
			get
			{
				return this.isClaimed_;
			}
			set
			{
				this.isClaimed_ = value;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06004246 RID: 16966 RVA: 0x000B462E File Offset: 0x000B282E
		// (set) Token: 0x06004247 RID: 16967 RVA: 0x000B4636 File Offset: 0x000B2836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CeilingNum
		{
			get
			{
				return this.ceilingNum_;
			}
			set
			{
				this.ceilingNum_ = value;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x000B463F File Offset: 0x000B283F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaCeilingAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x000B4647 File Offset: 0x000B2847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaCeiling);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x000B4658 File Offset: 0x000B2858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaCeiling other)
		{
			return other != null && (other == this || (this.IsClaimed == other.IsClaimed && this.CeilingNum == other.CeilingNum && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000B46B8 File Offset: 0x000B28B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsClaimed)
			{
				num ^= this.IsClaimed.GetHashCode();
			}
			if (this.CeilingNum != 0U)
			{
				num ^= this.CeilingNum.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x000B471E File Offset: 0x000B291E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x000B4726 File Offset: 0x000B2926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x000B4730 File Offset: 0x000B2930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CeilingNum != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CeilingNum);
			}
			if (this.IsClaimed)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsClaimed);
			}
			this.avatarList_.WriteTo(ref output, GachaCeiling._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x000B479C File Offset: 0x000B299C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsClaimed)
			{
				num += 2;
			}
			if (this.CeilingNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CeilingNum);
			}
			num += this.avatarList_.CalculateSize(GachaCeiling._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x000B47FC File Offset: 0x000B29FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaCeiling other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsClaimed)
			{
				this.IsClaimed = other.IsClaimed;
			}
			if (other.CeilingNum != 0U)
			{
				this.CeilingNum = other.CeilingNum;
			}
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x000B485D File Offset: 0x000B2A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x000B4868 File Offset: 0x000B2A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 48U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.avatarList_.AddEntriesFrom(ref input, GachaCeiling._repeated_avatarList_codec);
						}
					}
					else
					{
						this.IsClaimed = input.ReadBool();
					}
				}
				else
				{
					this.CeilingNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001A4C RID: 6732
		private static readonly MessageParser<GachaCeiling> _parser = new MessageParser<GachaCeiling>(() => new GachaCeiling());

		// Token: 0x04001A4D RID: 6733
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A4E RID: 6734
		public const int IsClaimedFieldNumber = 6;

		// Token: 0x04001A4F RID: 6735
		private bool isClaimed_;

		// Token: 0x04001A50 RID: 6736
		public const int CeilingNumFieldNumber = 1;

		// Token: 0x04001A51 RID: 6737
		private uint ceilingNum_;

		// Token: 0x04001A52 RID: 6738
		public const int AvatarListFieldNumber = 15;

		// Token: 0x04001A53 RID: 6739
		private static readonly FieldCodec<GachaCeilingAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<GachaCeilingAvatar>(122U, GachaCeilingAvatar.Parser);

		// Token: 0x04001A54 RID: 6740
		private readonly RepeatedField<GachaCeilingAvatar> avatarList_ = new RepeatedField<GachaCeilingAvatar>();
	}
}
