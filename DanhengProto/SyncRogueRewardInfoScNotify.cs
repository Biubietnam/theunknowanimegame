using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200129B RID: 4763
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueRewardInfoScNotify : IMessage<SyncRogueRewardInfoScNotify>, IMessage, IEquatable<SyncRogueRewardInfoScNotify>, IDeepCloneable<SyncRogueRewardInfoScNotify>, IBufferMessage
	{
		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0600D479 RID: 54393 RVA: 0x00237533 File Offset: 0x00235733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueRewardInfoScNotify> Parser
		{
			get
			{
				return SyncRogueRewardInfoScNotify._parser;
			}
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0600D47A RID: 54394 RVA: 0x0023753A File Offset: 0x0023573A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueRewardInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0600D47B RID: 54395 RVA: 0x0023754C File Offset: 0x0023574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueRewardInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600D47C RID: 54396 RVA: 0x00237553 File Offset: 0x00235753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueRewardInfoScNotify()
		{
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x0023755B File Offset: 0x0023575B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueRewardInfoScNotify(SyncRogueRewardInfoScNotify other) : this()
		{
			this.rogueScoreRewardInfo_ = ((other.rogueScoreRewardInfo_ != null) ? other.rogueScoreRewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D47E RID: 54398 RVA: 0x00237590 File Offset: 0x00235790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueRewardInfoScNotify Clone()
		{
			return new SyncRogueRewardInfoScNotify(this);
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0600D47F RID: 54399 RVA: 0x00237598 File Offset: 0x00235798
		// (set) Token: 0x0600D480 RID: 54400 RVA: 0x002375A0 File Offset: 0x002357A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo RogueScoreRewardInfo
		{
			get
			{
				return this.rogueScoreRewardInfo_;
			}
			set
			{
				this.rogueScoreRewardInfo_ = value;
			}
		}

		// Token: 0x0600D481 RID: 54401 RVA: 0x002375A9 File Offset: 0x002357A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueRewardInfoScNotify);
		}

		// Token: 0x0600D482 RID: 54402 RVA: 0x002375B7 File Offset: 0x002357B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueRewardInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueScoreRewardInfo, other.RogueScoreRewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D483 RID: 54403 RVA: 0x002375EC File Offset: 0x002357EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueScoreRewardInfo_ != null)
			{
				num ^= this.RogueScoreRewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D484 RID: 54404 RVA: 0x00237628 File Offset: 0x00235828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D485 RID: 54405 RVA: 0x00237630 File Offset: 0x00235830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D486 RID: 54406 RVA: 0x00237639 File Offset: 0x00235839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueScoreRewardInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueScoreRewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D487 RID: 54407 RVA: 0x0023766C File Offset: 0x0023586C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueScoreRewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueScoreRewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D488 RID: 54408 RVA: 0x002376AC File Offset: 0x002358AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueRewardInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueScoreRewardInfo_ != null)
			{
				if (this.rogueScoreRewardInfo_ == null)
				{
					this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
				}
				this.RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D489 RID: 54409 RVA: 0x00237700 File Offset: 0x00235900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D48A RID: 54410 RVA: 0x0023770C File Offset: 0x0023590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueScoreRewardInfo_ == null)
					{
						this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
					}
					input.ReadMessage(this.RogueScoreRewardInfo);
				}
			}
		}

		// Token: 0x04005505 RID: 21765
		private static readonly MessageParser<SyncRogueRewardInfoScNotify> _parser = new MessageParser<SyncRogueRewardInfoScNotify>(() => new SyncRogueRewardInfoScNotify());

		// Token: 0x04005506 RID: 21766
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005507 RID: 21767
		public const int RogueScoreRewardInfoFieldNumber = 10;

		// Token: 0x04005508 RID: 21768
		private RogueScoreRewardInfo rogueScoreRewardInfo_;
	}
}
