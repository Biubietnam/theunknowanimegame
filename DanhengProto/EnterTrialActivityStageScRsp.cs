using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000481 RID: 1153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterTrialActivityStageScRsp : IMessage<EnterTrialActivityStageScRsp>, IMessage, IEquatable<EnterTrialActivityStageScRsp>, IDeepCloneable<EnterTrialActivityStageScRsp>, IBufferMessage
	{
		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x0008D26F File Offset: 0x0008B46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterTrialActivityStageScRsp> Parser
		{
			get
			{
				return EnterTrialActivityStageScRsp._parser;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x0600335B RID: 13147 RVA: 0x0008D276 File Offset: 0x0008B476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterTrialActivityStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x0600335C RID: 13148 RVA: 0x0008D288 File Offset: 0x0008B488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterTrialActivityStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x0008D28F File Offset: 0x0008B48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTrialActivityStageScRsp()
		{
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x0008D298 File Offset: 0x0008B498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTrialActivityStageScRsp(EnterTrialActivityStageScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x0008D2E4 File Offset: 0x0008B4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterTrialActivityStageScRsp Clone()
		{
			return new EnterTrialActivityStageScRsp(this);
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06003360 RID: 13152 RVA: 0x0008D2EC File Offset: 0x0008B4EC
		// (set) Token: 0x06003361 RID: 13153 RVA: 0x0008D2F4 File Offset: 0x0008B4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06003362 RID: 13154 RVA: 0x0008D2FD File Offset: 0x0008B4FD
		// (set) Token: 0x06003363 RID: 13155 RVA: 0x0008D305 File Offset: 0x0008B505
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

		// Token: 0x06003364 RID: 13156 RVA: 0x0008D30E File Offset: 0x0008B50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterTrialActivityStageScRsp);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x0008D31C File Offset: 0x0008B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterTrialActivityStageScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x0008D36C File Offset: 0x0008B56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
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

		// Token: 0x06003367 RID: 13159 RVA: 0x0008D3C1 File Offset: 0x0008B5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x0008D3C9 File Offset: 0x0008B5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x0008D3D4 File Offset: 0x0008B5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BattleInfo);
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

		// Token: 0x0600336A RID: 13162 RVA: 0x0008D430 File Offset: 0x0008B630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
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

		// Token: 0x0600336B RID: 13163 RVA: 0x0008D488 File Offset: 0x0008B688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterTrialActivityStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x0008D4F0 File Offset: 0x0008B6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0008D4FC File Offset: 0x0008B6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
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
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x0400146A RID: 5226
		private static readonly MessageParser<EnterTrialActivityStageScRsp> _parser = new MessageParser<EnterTrialActivityStageScRsp>(() => new EnterTrialActivityStageScRsp());

		// Token: 0x0400146B RID: 5227
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400146C RID: 5228
		public const int BattleInfoFieldNumber = 12;

		// Token: 0x0400146D RID: 5229
		private SceneBattleInfo battleInfo_;

		// Token: 0x0400146E RID: 5230
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400146F RID: 5231
		private uint retcode_;
	}
}
