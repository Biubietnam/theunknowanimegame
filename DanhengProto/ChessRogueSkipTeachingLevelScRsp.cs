using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200029D RID: 669
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueSkipTeachingLevelScRsp : IMessage<ChessRogueSkipTeachingLevelScRsp>, IMessage, IEquatable<ChessRogueSkipTeachingLevelScRsp>, IDeepCloneable<ChessRogueSkipTeachingLevelScRsp>, IBufferMessage
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00055447 File Offset: 0x00053647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueSkipTeachingLevelScRsp> Parser
		{
			get
			{
				return ChessRogueSkipTeachingLevelScRsp._parser;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0005544E File Offset: 0x0005364E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueSkipTeachingLevelScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00055460 File Offset: 0x00053660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueSkipTeachingLevelScRsp.Descriptor;
			}
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00055467 File Offset: 0x00053667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSkipTeachingLevelScRsp()
		{
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00055470 File Offset: 0x00053670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSkipTeachingLevelScRsp(ChessRogueSkipTeachingLevelScRsp other) : this()
		{
			this.skipRewardList_ = ((other.skipRewardList_ != null) ? other.skipRewardList_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000554BC File Offset: 0x000536BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSkipTeachingLevelScRsp Clone()
		{
			return new ChessRogueSkipTeachingLevelScRsp(this);
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x000554C4 File Offset: 0x000536C4
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x000554CC File Offset: 0x000536CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList SkipRewardList
		{
			get
			{
				return this.skipRewardList_;
			}
			set
			{
				this.skipRewardList_ = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x000554D5 File Offset: 0x000536D5
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x000554DD File Offset: 0x000536DD
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

		// Token: 0x06001DDA RID: 7642 RVA: 0x000554E6 File Offset: 0x000536E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueSkipTeachingLevelScRsp);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000554F4 File Offset: 0x000536F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueSkipTeachingLevelScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.SkipRewardList, other.SkipRewardList) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00055544 File Offset: 0x00053744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.skipRewardList_ != null)
			{
				num ^= this.SkipRewardList.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00055599 File Offset: 0x00053799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000555A1 File Offset: 0x000537A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000555AC File Offset: 0x000537AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skipRewardList_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SkipRewardList);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00055608 File Offset: 0x00053808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.skipRewardList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkipRewardList);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00055660 File Offset: 0x00053860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueSkipTeachingLevelScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.skipRewardList_ != null)
			{
				if (this.skipRewardList_ == null)
				{
					this.SkipRewardList = new ItemList();
				}
				this.SkipRewardList.MergeFrom(other.SkipRewardList);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000556C8 File Offset: 0x000538C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000556D4 File Offset: 0x000538D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.skipRewardList_ == null)
					{
						this.SkipRewardList = new ItemList();
					}
					input.ReadMessage(this.SkipRewardList);
				}
			}
		}

		// Token: 0x04000C67 RID: 3175
		private static readonly MessageParser<ChessRogueSkipTeachingLevelScRsp> _parser = new MessageParser<ChessRogueSkipTeachingLevelScRsp>(() => new ChessRogueSkipTeachingLevelScRsp());

		// Token: 0x04000C68 RID: 3176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C69 RID: 3177
		public const int SkipRewardListFieldNumber = 1;

		// Token: 0x04000C6A RID: 3178
		private ItemList skipRewardList_;

		// Token: 0x04000C6B RID: 3179
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04000C6C RID: 3180
		private uint retcode_;
	}
}
