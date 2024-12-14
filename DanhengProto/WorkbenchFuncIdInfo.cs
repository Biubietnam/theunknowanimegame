using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200143D RID: 5181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchFuncIdInfo : IMessage<WorkbenchFuncIdInfo>, IMessage, IEquatable<WorkbenchFuncIdInfo>, IDeepCloneable<WorkbenchFuncIdInfo>, IBufferMessage
	{
		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x0600E722 RID: 59170 RVA: 0x00266380 File Offset: 0x00264580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchFuncIdInfo> Parser
		{
			get
			{
				return WorkbenchFuncIdInfo._parser;
			}
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x0600E723 RID: 59171 RVA: 0x00266387 File Offset: 0x00264587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchFuncIdInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x0600E724 RID: 59172 RVA: 0x00266399 File Offset: 0x00264599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchFuncIdInfo.Descriptor;
			}
		}

		// Token: 0x0600E725 RID: 59173 RVA: 0x002663A0 File Offset: 0x002645A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchFuncIdInfo()
		{
		}

		// Token: 0x0600E726 RID: 59174 RVA: 0x002663A8 File Offset: 0x002645A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchFuncIdInfo(WorkbenchFuncIdInfo other) : this()
		{
			this.isValid_ = other.isValid_;
			this.workbenchFuncId_ = other.workbenchFuncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E727 RID: 59175 RVA: 0x002663D9 File Offset: 0x002645D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchFuncIdInfo Clone()
		{
			return new WorkbenchFuncIdInfo(this);
		}

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x0600E728 RID: 59176 RVA: 0x002663E1 File Offset: 0x002645E1
		// (set) Token: 0x0600E729 RID: 59177 RVA: 0x002663E9 File Offset: 0x002645E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsValid
		{
			get
			{
				return this.isValid_;
			}
			set
			{
				this.isValid_ = value;
			}
		}

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x0600E72A RID: 59178 RVA: 0x002663F2 File Offset: 0x002645F2
		// (set) Token: 0x0600E72B RID: 59179 RVA: 0x002663FA File Offset: 0x002645FA
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

		// Token: 0x0600E72C RID: 59180 RVA: 0x00266403 File Offset: 0x00264603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchFuncIdInfo);
		}

		// Token: 0x0600E72D RID: 59181 RVA: 0x00266411 File Offset: 0x00264611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchFuncIdInfo other)
		{
			return other != null && (other == this || (this.IsValid == other.IsValid && this.WorkbenchFuncId == other.WorkbenchFuncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x00266450 File Offset: 0x00264650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsValid)
			{
				num ^= this.IsValid.GetHashCode();
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

		// Token: 0x0600E72F RID: 59183 RVA: 0x002664A8 File Offset: 0x002646A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E730 RID: 59184 RVA: 0x002664B0 File Offset: 0x002646B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x002664BC File Offset: 0x002646BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsValid)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsValid);
			}
			if (this.WorkbenchFuncId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.WorkbenchFuncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x00266518 File Offset: 0x00264718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsValid)
			{
				num += 2;
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

		// Token: 0x0600E733 RID: 59187 RVA: 0x00266564 File Offset: 0x00264764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchFuncIdInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsValid)
			{
				this.IsValid = other.IsValid;
			}
			if (other.WorkbenchFuncId != 0U)
			{
				this.WorkbenchFuncId = other.WorkbenchFuncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x002665B4 File Offset: 0x002647B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E735 RID: 59189 RVA: 0x002665C0 File Offset: 0x002647C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 120U)
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
					this.IsValid = input.ReadBool();
				}
			}
		}

		// Token: 0x04005BB2 RID: 23474
		private static readonly MessageParser<WorkbenchFuncIdInfo> _parser = new MessageParser<WorkbenchFuncIdInfo>(() => new WorkbenchFuncIdInfo());

		// Token: 0x04005BB3 RID: 23475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BB4 RID: 23476
		public const int IsValidFieldNumber = 5;

		// Token: 0x04005BB5 RID: 23477
		private bool isValid_;

		// Token: 0x04005BB6 RID: 23478
		public const int WorkbenchFuncIdFieldNumber = 15;

		// Token: 0x04005BB7 RID: 23479
		private uint workbenchFuncId_;
	}
}
