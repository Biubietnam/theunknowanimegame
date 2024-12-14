using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B95 RID: 2965
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonthCardRewardNotify : IMessage<MonthCardRewardNotify>, IMessage, IEquatable<MonthCardRewardNotify>, IDeepCloneable<MonthCardRewardNotify>, IBufferMessage
	{
		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x06008369 RID: 33641 RVA: 0x0015AFF9 File Offset: 0x001591F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonthCardRewardNotify> Parser
		{
			get
			{
				return MonthCardRewardNotify._parser;
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x0600836A RID: 33642 RVA: 0x0015B000 File Offset: 0x00159200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonthCardRewardNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x0600836B RID: 33643 RVA: 0x0015B012 File Offset: 0x00159212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x0015B019 File Offset: 0x00159219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRewardNotify()
		{
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x0015B021 File Offset: 0x00159221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRewardNotify(MonthCardRewardNotify other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0015B056 File Offset: 0x00159256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRewardNotify Clone()
		{
			return new MonthCardRewardNotify(this);
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x0600836F RID: 33647 RVA: 0x0015B05E File Offset: 0x0015925E
		// (set) Token: 0x06008370 RID: 33648 RVA: 0x0015B066 File Offset: 0x00159266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x0015B06F File Offset: 0x0015926F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardRewardNotify);
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x0015B07D File Offset: 0x0015927D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardRewardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x0015B0B0 File Offset: 0x001592B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x0015B0EC File Offset: 0x001592EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x0015B0F4 File Offset: 0x001592F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0015B0FD File Offset: 0x001592FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x0015B130 File Offset: 0x00159330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x0015B170 File Offset: 0x00159370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonthCardRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x0015B1C4 File Offset: 0x001593C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x0015B1D0 File Offset: 0x001593D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x04003247 RID: 12871
		private static readonly MessageParser<MonthCardRewardNotify> _parser = new MessageParser<MonthCardRewardNotify>(() => new MonthCardRewardNotify());

		// Token: 0x04003248 RID: 12872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003249 RID: 12873
		public const int RewardFieldNumber = 8;

		// Token: 0x0400324A RID: 12874
		private ItemList reward_;
	}
}
