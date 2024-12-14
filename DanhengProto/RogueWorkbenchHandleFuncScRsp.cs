using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001039 RID: 4153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueWorkbenchHandleFuncScRsp : IMessage<RogueWorkbenchHandleFuncScRsp>, IMessage, IEquatable<RogueWorkbenchHandleFuncScRsp>, IDeepCloneable<RogueWorkbenchHandleFuncScRsp>, IBufferMessage
	{
		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600B8B4 RID: 47284 RVA: 0x001EFE47 File Offset: 0x001EE047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWorkbenchHandleFuncScRsp> Parser
		{
			get
			{
				return RogueWorkbenchHandleFuncScRsp._parser;
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600B8B5 RID: 47285 RVA: 0x001EFE4E File Offset: 0x001EE04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchHandleFuncScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600B8B6 RID: 47286 RVA: 0x001EFE60 File Offset: 0x001EE060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWorkbenchHandleFuncScRsp.Descriptor;
			}
		}

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x001EFE67 File Offset: 0x001EE067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchHandleFuncScRsp()
		{
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x001EFE70 File Offset: 0x001EE070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchHandleFuncScRsp(RogueWorkbenchHandleFuncScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.targetFuncInfo_ = ((other.targetFuncInfo_ != null) ? other.targetFuncInfo_.Clone() : null);
			this.workbenchFuncId_ = other.workbenchFuncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x001EFEC8 File Offset: 0x001EE0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchHandleFuncScRsp Clone()
		{
			return new RogueWorkbenchHandleFuncScRsp(this);
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600B8BA RID: 47290 RVA: 0x001EFED0 File Offset: 0x001EE0D0
		// (set) Token: 0x0600B8BB RID: 47291 RVA: 0x001EFED8 File Offset: 0x001EE0D8
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

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600B8BC RID: 47292 RVA: 0x001EFEE1 File Offset: 0x001EE0E1
		// (set) Token: 0x0600B8BD RID: 47293 RVA: 0x001EFEE9 File Offset: 0x001EE0E9
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

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600B8BE RID: 47294 RVA: 0x001EFEF2 File Offset: 0x001EE0F2
		// (set) Token: 0x0600B8BF RID: 47295 RVA: 0x001EFEFA File Offset: 0x001EE0FA
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

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x001EFF03 File Offset: 0x001EE103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWorkbenchHandleFuncScRsp);
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x001EFF14 File Offset: 0x001EE114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWorkbenchHandleFuncScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.TargetFuncInfo, other.TargetFuncInfo) && this.WorkbenchFuncId == other.WorkbenchFuncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x001EFF74 File Offset: 0x001EE174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.targetFuncInfo_ != null)
			{
				num ^= this.TargetFuncInfo.GetHashCode();
			}
			if (this.WorkbenchFuncId != 0U)
			{
				num ^= this.WorkbenchFuncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x001EFFE2 File Offset: 0x001EE1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B8C4 RID: 47300 RVA: 0x001EFFEA File Offset: 0x001EE1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8C5 RID: 47301 RVA: 0x001EFFF4 File Offset: 0x001EE1F4
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
				output.WriteRawTag(74);
				output.WriteMessage(this.TargetFuncInfo);
			}
			if (this.WorkbenchFuncId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.WorkbenchFuncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x001F006C File Offset: 0x001EE26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.targetFuncInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetFuncInfo);
			}
			if (this.WorkbenchFuncId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorkbenchFuncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x001F00DC File Offset: 0x001EE2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWorkbenchHandleFuncScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x001F0158 File Offset: 0x001EE358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x001F0164 File Offset: 0x001EE364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 74U)
					{
						if (num != 104U)
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

		// Token: 0x04004AD7 RID: 19159
		private static readonly MessageParser<RogueWorkbenchHandleFuncScRsp> _parser = new MessageParser<RogueWorkbenchHandleFuncScRsp>(() => new RogueWorkbenchHandleFuncScRsp());

		// Token: 0x04004AD8 RID: 19160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AD9 RID: 19161
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04004ADA RID: 19162
		private uint retcode_;

		// Token: 0x04004ADB RID: 19163
		public const int TargetFuncInfoFieldNumber = 9;

		// Token: 0x04004ADC RID: 19164
		private WorkbenchFuncInfo targetFuncInfo_;

		// Token: 0x04004ADD RID: 19165
		public const int WorkbenchFuncIdFieldNumber = 13;

		// Token: 0x04004ADE RID: 19166
		private uint workbenchFuncId_;
	}
}
