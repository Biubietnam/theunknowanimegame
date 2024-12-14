using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012C9 RID: 4809
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeChallengeRewardScRsp : IMessage<TakeChallengeRewardScRsp>, IMessage, IEquatable<TakeChallengeRewardScRsp>, IDeepCloneable<TakeChallengeRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0600D67F RID: 54911 RVA: 0x0023C213 File Offset: 0x0023A413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeChallengeRewardScRsp> Parser
		{
			get
			{
				return TakeChallengeRewardScRsp._parser;
			}
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0600D680 RID: 54912 RVA: 0x0023C21A File Offset: 0x0023A41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeChallengeRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600D681 RID: 54913 RVA: 0x0023C22C File Offset: 0x0023A42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeChallengeRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D682 RID: 54914 RVA: 0x0023C233 File Offset: 0x0023A433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRewardScRsp()
		{
		}

		// Token: 0x0600D683 RID: 54915 RVA: 0x0023C248 File Offset: 0x0023A448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRewardScRsp(TakeChallengeRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.groupId_ = other.groupId_;
			this.takenRewardList_ = other.takenRewardList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x0023C295 File Offset: 0x0023A495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChallengeRewardScRsp Clone()
		{
			return new TakeChallengeRewardScRsp(this);
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0600D685 RID: 54917 RVA: 0x0023C29D File Offset: 0x0023A49D
		// (set) Token: 0x0600D686 RID: 54918 RVA: 0x0023C2A5 File Offset: 0x0023A4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0600D687 RID: 54919 RVA: 0x0023C2AE File Offset: 0x0023A4AE
		// (set) Token: 0x0600D688 RID: 54920 RVA: 0x0023C2B6 File Offset: 0x0023A4B6
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

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0600D689 RID: 54921 RVA: 0x0023C2BF File Offset: 0x0023A4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TakenChallengeRewardInfo> TakenRewardList
		{
			get
			{
				return this.takenRewardList_;
			}
		}

		// Token: 0x0600D68A RID: 54922 RVA: 0x0023C2C7 File Offset: 0x0023A4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeChallengeRewardScRsp);
		}

		// Token: 0x0600D68B RID: 54923 RVA: 0x0023C2D8 File Offset: 0x0023A4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeChallengeRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.GroupId == other.GroupId && this.takenRewardList_.Equals(other.takenRewardList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D68C RID: 54924 RVA: 0x0023C338 File Offset: 0x0023A538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			num ^= this.takenRewardList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D68D RID: 54925 RVA: 0x0023C39E File Offset: 0x0023A59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D68E RID: 54926 RVA: 0x0023C3A6 File Offset: 0x0023A5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D68F RID: 54927 RVA: 0x0023C3B0 File Offset: 0x0023A5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.takenRewardList_.WriteTo(ref output, TakeChallengeRewardScRsp._repeated_takenRewardList_codec);
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D690 RID: 54928 RVA: 0x0023C41C File Offset: 0x0023A61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			num += this.takenRewardList_.CalculateSize(TakeChallengeRewardScRsp._repeated_takenRewardList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D691 RID: 54929 RVA: 0x0023C488 File Offset: 0x0023A688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeChallengeRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this.takenRewardList_.Add(other.takenRewardList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D692 RID: 54930 RVA: 0x0023C4E9 File Offset: 0x0023A6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D693 RID: 54931 RVA: 0x0023C4F4 File Offset: 0x0023A6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 106U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.takenRewardList_.AddEntriesFrom(ref input, TakeChallengeRewardScRsp._repeated_takenRewardList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040055A5 RID: 21925
		private static readonly MessageParser<TakeChallengeRewardScRsp> _parser = new MessageParser<TakeChallengeRewardScRsp>(() => new TakeChallengeRewardScRsp());

		// Token: 0x040055A6 RID: 21926
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055A7 RID: 21927
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040055A8 RID: 21928
		private uint retcode_;

		// Token: 0x040055A9 RID: 21929
		public const int GroupIdFieldNumber = 14;

		// Token: 0x040055AA RID: 21930
		private uint groupId_;

		// Token: 0x040055AB RID: 21931
		public const int TakenRewardListFieldNumber = 13;

		// Token: 0x040055AC RID: 21932
		private static readonly FieldCodec<TakenChallengeRewardInfo> _repeated_takenRewardList_codec = FieldCodec.ForMessage<TakenChallengeRewardInfo>(106U, TakenChallengeRewardInfo.Parser);

		// Token: 0x040055AD RID: 21933
		private readonly RepeatedField<TakenChallengeRewardInfo> takenRewardList_ = new RepeatedField<TakenChallengeRewardInfo>();
	}
}
