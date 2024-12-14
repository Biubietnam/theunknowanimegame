using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200103B RID: 4155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueWorkbenchSelectFuncCsReq : IMessage<RogueWorkbenchSelectFuncCsReq>, IMessage, IEquatable<RogueWorkbenchSelectFuncCsReq>, IDeepCloneable<RogueWorkbenchSelectFuncCsReq>, IBufferMessage
	{
		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x001F0279 File Offset: 0x001EE479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWorkbenchSelectFuncCsReq> Parser
		{
			get
			{
				return RogueWorkbenchSelectFuncCsReq._parser;
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600B8CE RID: 47310 RVA: 0x001F0280 File Offset: 0x001EE480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchSelectFuncCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600B8CF RID: 47311 RVA: 0x001F0292 File Offset: 0x001EE492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWorkbenchSelectFuncCsReq.Descriptor;
			}
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x001F0299 File Offset: 0x001EE499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchSelectFuncCsReq()
		{
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x001F02A1 File Offset: 0x001EE4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchSelectFuncCsReq(RogueWorkbenchSelectFuncCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this.workbenchFuncId_ = other.workbenchFuncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x001F02D2 File Offset: 0x001EE4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWorkbenchSelectFuncCsReq Clone()
		{
			return new RogueWorkbenchSelectFuncCsReq(this);
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600B8D3 RID: 47315 RVA: 0x001F02DA File Offset: 0x001EE4DA
		// (set) Token: 0x0600B8D4 RID: 47316 RVA: 0x001F02E2 File Offset: 0x001EE4E2
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

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600B8D5 RID: 47317 RVA: 0x001F02EB File Offset: 0x001EE4EB
		// (set) Token: 0x0600B8D6 RID: 47318 RVA: 0x001F02F3 File Offset: 0x001EE4F3
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

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x001F02FC File Offset: 0x001EE4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWorkbenchSelectFuncCsReq);
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x001F030A File Offset: 0x001EE50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWorkbenchSelectFuncCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && this.WorkbenchFuncId == other.WorkbenchFuncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x001F0348 File Offset: 0x001EE548
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B8DA RID: 47322 RVA: 0x001F03A0 File Offset: 0x001EE5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B8DB RID: 47323 RVA: 0x001F03A8 File Offset: 0x001EE5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8DC RID: 47324 RVA: 0x001F03B4 File Offset: 0x001EE5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PropEntityId);
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

		// Token: 0x0600B8DD RID: 47325 RVA: 0x001F0410 File Offset: 0x001EE610
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B8DE RID: 47326 RVA: 0x001F0468 File Offset: 0x001EE668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWorkbenchSelectFuncCsReq other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8DF RID: 47327 RVA: 0x001F04B8 File Offset: 0x001EE6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x001F04C4 File Offset: 0x001EE6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
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
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004AE0 RID: 19168
		private static readonly MessageParser<RogueWorkbenchSelectFuncCsReq> _parser = new MessageParser<RogueWorkbenchSelectFuncCsReq>(() => new RogueWorkbenchSelectFuncCsReq());

		// Token: 0x04004AE1 RID: 19169
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE2 RID: 19170
		public const int PropEntityIdFieldNumber = 2;

		// Token: 0x04004AE3 RID: 19171
		private uint propEntityId_;

		// Token: 0x04004AE4 RID: 19172
		public const int WorkbenchFuncIdFieldNumber = 9;

		// Token: 0x04004AE5 RID: 19173
		private uint workbenchFuncId_;
	}
}
