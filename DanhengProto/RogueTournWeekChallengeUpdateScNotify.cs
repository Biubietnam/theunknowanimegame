using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001025 RID: 4133
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournWeekChallengeUpdateScNotify : IMessage<RogueTournWeekChallengeUpdateScNotify>, IMessage, IEquatable<RogueTournWeekChallengeUpdateScNotify>, IDeepCloneable<RogueTournWeekChallengeUpdateScNotify>, IBufferMessage
	{
		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600B7CD RID: 47053 RVA: 0x001ED38F File Offset: 0x001EB58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournWeekChallengeUpdateScNotify> Parser
		{
			get
			{
				return RogueTournWeekChallengeUpdateScNotify._parser;
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600B7CE RID: 47054 RVA: 0x001ED396 File Offset: 0x001EB596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournWeekChallengeUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600B7CF RID: 47055 RVA: 0x001ED3A8 File Offset: 0x001EB5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournWeekChallengeUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x001ED3AF File Offset: 0x001EB5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournWeekChallengeUpdateScNotify()
		{
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x001ED3B7 File Offset: 0x001EB5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournWeekChallengeUpdateScNotify(RogueTournWeekChallengeUpdateScNotify other) : this()
		{
			this.extraScoreInfo_ = ((other.extraScoreInfo_ != null) ? other.extraScoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x001ED3EC File Offset: 0x001EB5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournWeekChallengeUpdateScNotify Clone()
		{
			return new RogueTournWeekChallengeUpdateScNotify(this);
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600B7D3 RID: 47059 RVA: 0x001ED3F4 File Offset: 0x001EB5F4
		// (set) Token: 0x0600B7D4 RID: 47060 RVA: 0x001ED3FC File Offset: 0x001EB5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraScoreInfo ExtraScoreInfo
		{
			get
			{
				return this.extraScoreInfo_;
			}
			set
			{
				this.extraScoreInfo_ = value;
			}
		}

		// Token: 0x0600B7D5 RID: 47061 RVA: 0x001ED405 File Offset: 0x001EB605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournWeekChallengeUpdateScNotify);
		}

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x001ED413 File Offset: 0x001EB613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournWeekChallengeUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ExtraScoreInfo, other.ExtraScoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x001ED448 File Offset: 0x001EB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.extraScoreInfo_ != null)
			{
				num ^= this.ExtraScoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x001ED484 File Offset: 0x001EB684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x001ED48C File Offset: 0x001EB68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7DA RID: 47066 RVA: 0x001ED495 File Offset: 0x001EB695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.extraScoreInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ExtraScoreInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x001ED4C8 File Offset: 0x001EB6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.extraScoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ExtraScoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x001ED508 File Offset: 0x001EB708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournWeekChallengeUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.extraScoreInfo_ != null)
			{
				if (this.extraScoreInfo_ == null)
				{
					this.ExtraScoreInfo = new ExtraScoreInfo();
				}
				this.ExtraScoreInfo.MergeFrom(other.ExtraScoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x001ED55C File Offset: 0x001EB75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x001ED568 File Offset: 0x001EB768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.extraScoreInfo_ == null)
					{
						this.ExtraScoreInfo = new ExtraScoreInfo();
					}
					input.ReadMessage(this.ExtraScoreInfo);
				}
			}
		}

		// Token: 0x04004A77 RID: 19063
		private static readonly MessageParser<RogueTournWeekChallengeUpdateScNotify> _parser = new MessageParser<RogueTournWeekChallengeUpdateScNotify>(() => new RogueTournWeekChallengeUpdateScNotify());

		// Token: 0x04004A78 RID: 19064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A79 RID: 19065
		public const int ExtraScoreInfoFieldNumber = 6;

		// Token: 0x04004A7A RID: 19066
		private ExtraScoreInfo extraScoreInfo_;
	}
}
