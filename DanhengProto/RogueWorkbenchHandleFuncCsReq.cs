using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001037 RID: 4151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueWorkbenchHandleFuncCsReq : IMessage<RogueWorkbenchHandleFuncCsReq>, IMessage, IEquatable<RogueWorkbenchHandleFuncCsReq>, IDeepCloneable<RogueWorkbenchHandleFuncCsReq>, IBufferMessage
	{
		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600B89B RID: 47259 RVA: 0x001EF9EB File Offset: 0x001EDBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWorkbenchHandleFuncCsReq> Parser
		{
			get
			{
				return RogueWorkbenchHandleFuncCsReq._parser;
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600B89C RID: 47260 RVA: 0x001EF9F2 File Offset: 0x001EDBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchHandleFuncCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600B89D RID: 47261 RVA: 0x001EFA04 File Offset: 0x001EDC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWorkbenchHandleFuncCsReq.Descriptor;
			}
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x001EFA0B File Offset: 0x001EDC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchHandleFuncCsReq()
		{
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x001EFA14 File Offset: 0x001EDC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchHandleFuncCsReq(RogueWorkbenchHandleFuncCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this.workbenchFuncId_ = other.workbenchFuncId_;
			this.workbenchContent_ = ((other.workbenchContent_ != null) ? other.workbenchContent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x001EFA6C File Offset: 0x001EDC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchHandleFuncCsReq Clone()
		{
			return new RogueWorkbenchHandleFuncCsReq(this);
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600B8A1 RID: 47265 RVA: 0x001EFA74 File Offset: 0x001EDC74
		// (set) Token: 0x0600B8A2 RID: 47266 RVA: 0x001EFA7C File Offset: 0x001EDC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x001EFA85 File Offset: 0x001EDC85
		// (set) Token: 0x0600B8A4 RID: 47268 RVA: 0x001EFA8D File Offset: 0x001EDC8D
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

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x001EFA96 File Offset: 0x001EDC96
		// (set) Token: 0x0600B8A6 RID: 47270 RVA: 0x001EFA9E File Offset: 0x001EDC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchContentInfo WorkbenchContent
		{
			get
			{
				return this.workbenchContent_;
			}
			set
			{
				this.workbenchContent_ = value;
			}
		}

		// Token: 0x0600B8A7 RID: 47271 RVA: 0x001EFAA7 File Offset: 0x001EDCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWorkbenchHandleFuncCsReq);
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x001EFAB8 File Offset: 0x001EDCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWorkbenchHandleFuncCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && this.WorkbenchFuncId == other.WorkbenchFuncId && object.Equals(this.WorkbenchContent, other.WorkbenchContent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x001EFB18 File Offset: 0x001EDD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this.WorkbenchFuncId != 0U)
			{
				num ^= this.WorkbenchFuncId.GetHashCode();
			}
			if (this.workbenchContent_ != null)
			{
				num ^= this.WorkbenchContent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B8AA RID: 47274 RVA: 0x001EFB86 File Offset: 0x001EDD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B8AB RID: 47275 RVA: 0x001EFB8E File Offset: 0x001EDD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8AC RID: 47276 RVA: 0x001EFB98 File Offset: 0x001EDD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorkbenchFuncId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.WorkbenchFuncId);
			}
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.workbenchContent_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.WorkbenchContent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8AD RID: 47277 RVA: 0x001EFC10 File Offset: 0x001EDE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this.WorkbenchFuncId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorkbenchFuncId);
			}
			if (this.workbenchContent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WorkbenchContent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B8AE RID: 47278 RVA: 0x001EFC80 File Offset: 0x001EDE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWorkbenchHandleFuncCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			if (other.WorkbenchFuncId != 0U)
			{
				this.WorkbenchFuncId = other.WorkbenchFuncId;
			}
			if (other.workbenchContent_ != null)
			{
				if (this.workbenchContent_ == null)
				{
					this.WorkbenchContent = new RogueWorkbenchContentInfo();
				}
				this.WorkbenchContent.MergeFrom(other.WorkbenchContent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x001EFCFC File Offset: 0x001EDEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x001EFD08 File Offset: 0x001EDF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 40U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.workbenchContent_ == null)
							{
								this.WorkbenchContent = new RogueWorkbenchContentInfo();
							}
							input.ReadMessage(this.WorkbenchContent);
						}
					}
					else
					{
						this.PropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.WorkbenchFuncId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004ACE RID: 19150
		private static readonly MessageParser<RogueWorkbenchHandleFuncCsReq> _parser = new MessageParser<RogueWorkbenchHandleFuncCsReq>(() => new RogueWorkbenchHandleFuncCsReq());

		// Token: 0x04004ACF RID: 19151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AD0 RID: 19152
		public const int PropEntityIdFieldNumber = 5;

		// Token: 0x04004AD1 RID: 19153
		private uint propEntityId_;

		// Token: 0x04004AD2 RID: 19154
		public const int WorkbenchFuncIdFieldNumber = 4;

		// Token: 0x04004AD3 RID: 19155
		private uint workbenchFuncId_;

		// Token: 0x04004AD4 RID: 19156
		public const int WorkbenchContentFieldNumber = 10;

		// Token: 0x04004AD5 RID: 19157
		private RogueWorkbenchContentInfo workbenchContent_;
	}
}
