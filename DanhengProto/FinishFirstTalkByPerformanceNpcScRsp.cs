using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200057D RID: 1405
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishFirstTalkByPerformanceNpcScRsp : IMessage<FinishFirstTalkByPerformanceNpcScRsp>, IMessage, IEquatable<FinishFirstTalkByPerformanceNpcScRsp>, IDeepCloneable<FinishFirstTalkByPerformanceNpcScRsp>, IBufferMessage
	{
		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x000AB537 File Offset: 0x000A9737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishFirstTalkByPerformanceNpcScRsp> Parser
		{
			get
			{
				return FinishFirstTalkByPerformanceNpcScRsp._parser;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06003EB1 RID: 16049 RVA: 0x000AB53E File Offset: 0x000A973E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishFirstTalkByPerformanceNpcScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x000AB550 File Offset: 0x000A9750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishFirstTalkByPerformanceNpcScRsp.Descriptor;
			}
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x000AB557 File Offset: 0x000A9757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkByPerformanceNpcScRsp()
		{
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x000AB560 File Offset: 0x000A9760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkByPerformanceNpcScRsp(FinishFirstTalkByPerformanceNpcScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.performanceId_ = other.performanceId_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x000AB5B8 File Offset: 0x000A97B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkByPerformanceNpcScRsp Clone()
		{
			return new FinishFirstTalkByPerformanceNpcScRsp(this);
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x000AB5C0 File Offset: 0x000A97C0
		// (set) Token: 0x06003EB7 RID: 16055 RVA: 0x000AB5C8 File Offset: 0x000A97C8
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

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x000AB5D1 File Offset: 0x000A97D1
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x000AB5D9 File Offset: 0x000A97D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PerformanceId
		{
			get
			{
				return this.performanceId_;
			}
			set
			{
				this.performanceId_ = value;
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x000AB5E2 File Offset: 0x000A97E2
		// (set) Token: 0x06003EBB RID: 16059 RVA: 0x000AB5EA File Offset: 0x000A97EA
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

		// Token: 0x06003EBC RID: 16060 RVA: 0x000AB5F3 File Offset: 0x000A97F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishFirstTalkByPerformanceNpcScRsp);
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x000AB604 File Offset: 0x000A9804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishFirstTalkByPerformanceNpcScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.PerformanceId == other.PerformanceId && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x000AB664 File Offset: 0x000A9864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.PerformanceId != 0U)
			{
				num ^= this.PerformanceId.GetHashCode();
			}
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

		// Token: 0x06003EBF RID: 16063 RVA: 0x000AB6D2 File Offset: 0x000A98D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x000AB6DA File Offset: 0x000A98DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x000AB6E4 File Offset: 0x000A98E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.PerformanceId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PerformanceId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x000AB75C File Offset: 0x000A995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.PerformanceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PerformanceId);
			}
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

		// Token: 0x06003EC3 RID: 16067 RVA: 0x000AB7CC File Offset: 0x000A99CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishFirstTalkByPerformanceNpcScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.PerformanceId != 0U)
			{
				this.PerformanceId = other.PerformanceId;
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

		// Token: 0x06003EC4 RID: 16068 RVA: 0x000AB848 File Offset: 0x000A9A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x000AB854 File Offset: 0x000A9A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 40U)
					{
						if (num != 112U)
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
						this.PerformanceId = input.ReadUInt32();
					}
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

		// Token: 0x04001901 RID: 6401
		private static readonly MessageParser<FinishFirstTalkByPerformanceNpcScRsp> _parser = new MessageParser<FinishFirstTalkByPerformanceNpcScRsp>(() => new FinishFirstTalkByPerformanceNpcScRsp());

		// Token: 0x04001902 RID: 6402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001903 RID: 6403
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04001904 RID: 6404
		private uint retcode_;

		// Token: 0x04001905 RID: 6405
		public const int PerformanceIdFieldNumber = 5;

		// Token: 0x04001906 RID: 6406
		private uint performanceId_;

		// Token: 0x04001907 RID: 6407
		public const int RewardFieldNumber = 4;

		// Token: 0x04001908 RID: 6408
		private ItemList reward_;
	}
}
