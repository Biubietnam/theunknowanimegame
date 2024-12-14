using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200046F RID: 1135
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSummonActivityStageCsReq : IMessage<EnterSummonActivityStageCsReq>, IMessage, IEquatable<EnterSummonActivityStageCsReq>, IDeepCloneable<EnterSummonActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x0008B0E7 File Offset: 0x000892E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSummonActivityStageCsReq> Parser
		{
			get
			{
				return EnterSummonActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x0008B0EE File Offset: 0x000892EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSummonActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x0008B100 File Offset: 0x00089300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSummonActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x0008B107 File Offset: 0x00089307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSummonActivityStageCsReq()
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x0008B11C File Offset: 0x0008931C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSummonActivityStageCsReq(EnterSummonActivityStageCsReq other) : this()
		{
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.groupId_ = other.groupId_;
			this.avatarList_ = other.avatarList_.Clone();
			this.pHNOLPNNJCE_ = ((other.pHNOLPNNJCE_ != null) ? other.pHNOLPNNJCE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x0008B185 File Offset: 0x00089385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSummonActivityStageCsReq Clone()
		{
			return new EnterSummonActivityStageCsReq(this);
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x0008B18D File Offset: 0x0008938D
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x0008B195 File Offset: 0x00089395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x0008B19E File Offset: 0x0008939E
		// (set) Token: 0x06003292 RID: 12946 RVA: 0x0008B1A6 File Offset: 0x000893A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x0008B1AF File Offset: 0x000893AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PMCFMHJGKCE> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x0008B1B7 File Offset: 0x000893B7
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x0008B1BF File Offset: 0x000893BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PMCFMHJGKCE PHNOLPNNJCE
		{
			get
			{
				return this.pHNOLPNNJCE_;
			}
			set
			{
				this.pHNOLPNNJCE_ = value;
			}
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x0008B1C8 File Offset: 0x000893C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSummonActivityStageCsReq);
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x0008B1D8 File Offset: 0x000893D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSummonActivityStageCsReq other)
		{
			return other != null && (other == this || (this.AHFNGPLDAII == other.AHFNGPLDAII && this.GroupId == other.GroupId && this.avatarList_.Equals(other.avatarList_) && object.Equals(this.PHNOLPNNJCE, other.PHNOLPNNJCE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x0008B24C File Offset: 0x0008944C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.pHNOLPNNJCE_ != null)
			{
				num ^= this.PHNOLPNNJCE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x0008B2C8 File Offset: 0x000894C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x0008B2D0 File Offset: 0x000894D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x0008B2DC File Offset: 0x000894DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GroupId);
			}
			this.avatarList_.WriteTo(ref output, EnterSummonActivityStageCsReq._repeated_avatarList_codec);
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this.pHNOLPNNJCE_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PHNOLPNNJCE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x0008B364 File Offset: 0x00089564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			num += this.avatarList_.CalculateSize(EnterSummonActivityStageCsReq._repeated_avatarList_codec);
			if (this.pHNOLPNNJCE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PHNOLPNNJCE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0008B3E8 File Offset: 0x000895E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSummonActivityStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.pHNOLPNNJCE_ != null)
			{
				if (this.pHNOLPNNJCE_ == null)
				{
					this.PHNOLPNNJCE = new PMCFMHJGKCE();
				}
				this.PHNOLPNNJCE.MergeFrom(other.PHNOLPNNJCE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x0008B475 File Offset: 0x00089675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x0008B480 File Offset: 0x00089680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						this.avatarList_.AddEntriesFrom(ref input, EnterSummonActivityStageCsReq._repeated_avatarList_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.AHFNGPLDAII = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.pHNOLPNNJCE_ == null)
						{
							this.PHNOLPNNJCE = new PMCFMHJGKCE();
						}
						input.ReadMessage(this.PHNOLPNNJCE);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001421 RID: 5153
		private static readonly MessageParser<EnterSummonActivityStageCsReq> _parser = new MessageParser<EnterSummonActivityStageCsReq>(() => new EnterSummonActivityStageCsReq());

		// Token: 0x04001422 RID: 5154
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001423 RID: 5155
		public const int AHFNGPLDAIIFieldNumber = 9;

		// Token: 0x04001424 RID: 5156
		private uint aHFNGPLDAII_;

		// Token: 0x04001425 RID: 5157
		public const int GroupIdFieldNumber = 2;

		// Token: 0x04001426 RID: 5158
		private uint groupId_;

		// Token: 0x04001427 RID: 5159
		public const int AvatarListFieldNumber = 6;

		// Token: 0x04001428 RID: 5160
		private static readonly FieldCodec<PMCFMHJGKCE> _repeated_avatarList_codec = FieldCodec.ForMessage<PMCFMHJGKCE>(50U, PMCFMHJGKCE.Parser);

		// Token: 0x04001429 RID: 5161
		private readonly RepeatedField<PMCFMHJGKCE> avatarList_ = new RepeatedField<PMCFMHJGKCE>();

		// Token: 0x0400142A RID: 5162
		public const int PHNOLPNNJCEFieldNumber = 11;

		// Token: 0x0400142B RID: 5163
		private PMCFMHJGKCE pHNOLPNNJCE_;
	}
}
