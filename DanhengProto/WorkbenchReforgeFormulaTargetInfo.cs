using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001447 RID: 5191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchReforgeFormulaTargetInfo : IMessage<WorkbenchReforgeFormulaTargetInfo>, IMessage, IEquatable<WorkbenchReforgeFormulaTargetInfo>, IDeepCloneable<WorkbenchReforgeFormulaTargetInfo>, IBufferMessage
	{
		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x0600E7AF RID: 59311 RVA: 0x002680C1 File Offset: 0x002662C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchReforgeFormulaTargetInfo> Parser
		{
			get
			{
				return WorkbenchReforgeFormulaTargetInfo._parser;
			}
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x002680C8 File Offset: 0x002662C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeFormulaTargetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x0600E7B1 RID: 59313 RVA: 0x002680DA File Offset: 0x002662DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchReforgeFormulaTargetInfo.Descriptor;
			}
		}

		// Token: 0x0600E7B2 RID: 59314 RVA: 0x002680E1 File Offset: 0x002662E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaTargetInfo()
		{
		}

		// Token: 0x0600E7B3 RID: 59315 RVA: 0x002680E9 File Offset: 0x002662E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaTargetInfo(WorkbenchReforgeFormulaTargetInfo other) : this()
		{
			this.targetReforgeFormulaId_ = other.targetReforgeFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7B4 RID: 59316 RVA: 0x0026810E File Offset: 0x0026630E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchReforgeFormulaTargetInfo Clone()
		{
			return new WorkbenchReforgeFormulaTargetInfo(this);
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x0600E7B5 RID: 59317 RVA: 0x00268116 File Offset: 0x00266316
		// (set) Token: 0x0600E7B6 RID: 59318 RVA: 0x0026811E File Offset: 0x0026631E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetReforgeFormulaId
		{
			get
			{
				return this.targetReforgeFormulaId_;
			}
			set
			{
				this.targetReforgeFormulaId_ = value;
			}
		}

		// Token: 0x0600E7B7 RID: 59319 RVA: 0x00268127 File Offset: 0x00266327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchReforgeFormulaTargetInfo);
		}

		// Token: 0x0600E7B8 RID: 59320 RVA: 0x00268135 File Offset: 0x00266335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchReforgeFormulaTargetInfo other)
		{
			return other != null && (other == this || (this.TargetReforgeFormulaId == other.TargetReforgeFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7B9 RID: 59321 RVA: 0x00268164 File Offset: 0x00266364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetReforgeFormulaId != 0U)
			{
				num ^= this.TargetReforgeFormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E7BA RID: 59322 RVA: 0x002681A3 File Offset: 0x002663A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E7BB RID: 59323 RVA: 0x002681AB File Offset: 0x002663AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7BC RID: 59324 RVA: 0x002681B4 File Offset: 0x002663B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetReforgeFormulaId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.TargetReforgeFormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7BD RID: 59325 RVA: 0x002681E8 File Offset: 0x002663E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetReforgeFormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetReforgeFormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7BE RID: 59326 RVA: 0x00268226 File Offset: 0x00266426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchReforgeFormulaTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetReforgeFormulaId != 0U)
			{
				this.TargetReforgeFormulaId = other.TargetReforgeFormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7BF RID: 59327 RVA: 0x00268257 File Offset: 0x00266457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x00268260 File Offset: 0x00266460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TargetReforgeFormulaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005BEF RID: 23535
		private static readonly MessageParser<WorkbenchReforgeFormulaTargetInfo> _parser = new MessageParser<WorkbenchReforgeFormulaTargetInfo>(() => new WorkbenchReforgeFormulaTargetInfo());

		// Token: 0x04005BF0 RID: 23536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BF1 RID: 23537
		public const int TargetReforgeFormulaIdFieldNumber = 11;

		// Token: 0x04005BF2 RID: 23538
		private uint targetReforgeFormulaId_;
	}
}
