using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200103D RID: 4157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueWorkbenchSelectFuncScRsp : IMessage<RogueWorkbenchSelectFuncScRsp>, IMessage, IEquatable<RogueWorkbenchSelectFuncScRsp>, IDeepCloneable<RogueWorkbenchSelectFuncScRsp>, IBufferMessage
	{
		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600B8E4 RID: 47332 RVA: 0x001F05DB File Offset: 0x001EE7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWorkbenchSelectFuncScRsp> Parser
		{
			get
			{
				return RogueWorkbenchSelectFuncScRsp._parser;
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x001F05E2 File Offset: 0x001EE7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchSelectFuncScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600B8E6 RID: 47334 RVA: 0x001F05F4 File Offset: 0x001EE7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWorkbenchSelectFuncScRsp.Descriptor;
			}
		}

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x001F05FB File Offset: 0x001EE7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchSelectFuncScRsp()
		{
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x001F0604 File Offset: 0x001EE804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchSelectFuncScRsp(RogueWorkbenchSelectFuncScRsp other) : this()
		{
			this.targetFuncInfo_ = ((other.targetFuncInfo_ != null) ? other.targetFuncInfo_.Clone() : null);
			this.workbenchFuncId_ = other.workbenchFuncId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x001F065C File Offset: 0x001EE85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchSelectFuncScRsp Clone()
		{
			return new RogueWorkbenchSelectFuncScRsp(this);
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600B8EA RID: 47338 RVA: 0x001F0664 File Offset: 0x001EE864
		// (set) Token: 0x0600B8EB RID: 47339 RVA: 0x001F066C File Offset: 0x001EE86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchFuncInfo TargetFuncInfo
		{
			get
			{
				return this.targetFuncInfo_;
			}
			set
			{
				this.targetFuncInfo_ = value;
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600B8EC RID: 47340 RVA: 0x001F0675 File Offset: 0x001EE875
		// (set) Token: 0x0600B8ED RID: 47341 RVA: 0x001F067D File Offset: 0x001EE87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorkbenchFuncId
		{
			get
			{
				return this.workbenchFuncId_;
			}
			set
			{
				this.workbenchFuncId_ = value;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600B8EE RID: 47342 RVA: 0x001F0686 File Offset: 0x001EE886
		// (set) Token: 0x0600B8EF RID: 47343 RVA: 0x001F068E File Offset: 0x001EE88E
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

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x001F0697 File Offset: 0x001EE897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWorkbenchSelectFuncScRsp);
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x001F06A8 File Offset: 0x001EE8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWorkbenchSelectFuncScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.TargetFuncInfo, other.TargetFuncInfo) && this.WorkbenchFuncId == other.WorkbenchFuncId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x001F0708 File Offset: 0x001EE908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.targetFuncInfo_ != null)
			{
				num ^= this.TargetFuncInfo.GetHashCode();
			}
			if (this.WorkbenchFuncId != 0U)
			{
				num ^= this.WorkbenchFuncId.GetHashCode();
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

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x001F0776 File Offset: 0x001EE976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B8F4 RID: 47348 RVA: 0x001F077E File Offset: 0x001EE97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x001F0788 File Offset: 0x001EE988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.targetFuncInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TargetFuncInfo);
			}
			if (this.WorkbenchFuncId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.WorkbenchFuncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x001F0800 File Offset: 0x001EEA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.targetFuncInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetFuncInfo);
			}
			if (this.WorkbenchFuncId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorkbenchFuncId);
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

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x001F0870 File Offset: 0x001EEA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWorkbenchSelectFuncScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.targetFuncInfo_ != null)
			{
				if (this.targetFuncInfo_ == null)
				{
					this.TargetFuncInfo = new WorkbenchFuncInfo();
				}
				this.TargetFuncInfo.MergeFrom(other.TargetFuncInfo);
			}
			if (other.WorkbenchFuncId != 0U)
			{
				this.WorkbenchFuncId = other.WorkbenchFuncId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x001F08EC File Offset: 0x001EEAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x001F08F8 File Offset: 0x001EEAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 58U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WorkbenchFuncId = input.ReadUInt32();
						}
					}
					else
					{
						if (this.targetFuncInfo_ == null)
						{
							this.TargetFuncInfo = new WorkbenchFuncInfo();
						}
						input.ReadMessage(this.TargetFuncInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004AE7 RID: 19175
		private static readonly MessageParser<RogueWorkbenchSelectFuncScRsp> _parser = new MessageParser<RogueWorkbenchSelectFuncScRsp>(() => new RogueWorkbenchSelectFuncScRsp());

		// Token: 0x04004AE8 RID: 19176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE9 RID: 19177
		public const int TargetFuncInfoFieldNumber = 7;

		// Token: 0x04004AEA RID: 19178
		private WorkbenchFuncInfo targetFuncInfo_;

		// Token: 0x04004AEB RID: 19179
		public const int WorkbenchFuncIdFieldNumber = 9;

		// Token: 0x04004AEC RID: 19180
		private uint workbenchFuncId_;

		// Token: 0x04004AED RID: 19181
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04004AEE RID: 19182
		private uint retcode_;
	}
}
