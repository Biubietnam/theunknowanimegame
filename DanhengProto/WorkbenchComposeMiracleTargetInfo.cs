using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001437 RID: 5175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchComposeMiracleTargetInfo : IMessage<WorkbenchComposeMiracleTargetInfo>, IMessage, IEquatable<WorkbenchComposeMiracleTargetInfo>, IDeepCloneable<WorkbenchComposeMiracleTargetInfo>, IBufferMessage
	{
		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x0600E6E1 RID: 59105 RVA: 0x00265A5D File Offset: 0x00263C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchComposeMiracleTargetInfo> Parser
		{
			get
			{
				return WorkbenchComposeMiracleTargetInfo._parser;
			}
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x0600E6E2 RID: 59106 RVA: 0x00265A64 File Offset: 0x00263C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchComposeMiracleTargetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x0600E6E3 RID: 59107 RVA: 0x00265A76 File Offset: 0x00263C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchComposeMiracleTargetInfo.Descriptor;
			}
		}

		// Token: 0x0600E6E4 RID: 59108 RVA: 0x00265A7D File Offset: 0x00263C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleTargetInfo()
		{
		}

		// Token: 0x0600E6E5 RID: 59109 RVA: 0x00265A90 File Offset: 0x00263C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleTargetInfo(WorkbenchComposeMiracleTargetInfo other) : this()
		{
			this.targetComposeMiracleIdList_ = other.targetComposeMiracleIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6E6 RID: 59110 RVA: 0x00265ABA File Offset: 0x00263CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchComposeMiracleTargetInfo Clone()
		{
			return new WorkbenchComposeMiracleTargetInfo(this);
		}

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x0600E6E7 RID: 59111 RVA: 0x00265AC2 File Offset: 0x00263CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TargetComposeMiracleIdList
		{
			get
			{
				return this.targetComposeMiracleIdList_;
			}
		}

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x00265ACA File Offset: 0x00263CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchComposeMiracleTargetInfo);
		}

		// Token: 0x0600E6E9 RID: 59113 RVA: 0x00265AD8 File Offset: 0x00263CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchComposeMiracleTargetInfo other)
		{
			return other != null && (other == this || (this.targetComposeMiracleIdList_.Equals(other.targetComposeMiracleIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6EA RID: 59114 RVA: 0x00265B0C File Offset: 0x00263D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.targetComposeMiracleIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E6EB RID: 59115 RVA: 0x00265B40 File Offset: 0x00263D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E6EC RID: 59116 RVA: 0x00265B48 File Offset: 0x00263D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6ED RID: 59117 RVA: 0x00265B51 File Offset: 0x00263D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.targetComposeMiracleIdList_.WriteTo(ref output, WorkbenchComposeMiracleTargetInfo._repeated_targetComposeMiracleIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6EE RID: 59118 RVA: 0x00265B78 File Offset: 0x00263D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.targetComposeMiracleIdList_.CalculateSize(WorkbenchComposeMiracleTargetInfo._repeated_targetComposeMiracleIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E6EF RID: 59119 RVA: 0x00265BB1 File Offset: 0x00263DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchComposeMiracleTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.targetComposeMiracleIdList_.Add(other.targetComposeMiracleIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x00265BDF File Offset: 0x00263DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6F1 RID: 59121 RVA: 0x00265BE8 File Offset: 0x00263DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.targetComposeMiracleIdList_.AddEntriesFrom(ref input, WorkbenchComposeMiracleTargetInfo._repeated_targetComposeMiracleIdList_codec);
				}
			}
		}

		// Token: 0x04005B9D RID: 23453
		private static readonly MessageParser<WorkbenchComposeMiracleTargetInfo> _parser = new MessageParser<WorkbenchComposeMiracleTargetInfo>(() => new WorkbenchComposeMiracleTargetInfo());

		// Token: 0x04005B9E RID: 23454
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B9F RID: 23455
		public const int TargetComposeMiracleIdListFieldNumber = 8;

		// Token: 0x04005BA0 RID: 23456
		private static readonly FieldCodec<uint> _repeated_targetComposeMiracleIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04005BA1 RID: 23457
		private readonly RepeatedField<uint> targetComposeMiracleIdList_ = new RepeatedField<uint>();
	}
}
