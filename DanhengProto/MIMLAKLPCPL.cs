using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AD5 RID: 2773
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MIMLAKLPCPL : IMessage<MIMLAKLPCPL>, IMessage, IEquatable<MIMLAKLPCPL>, IDeepCloneable<MIMLAKLPCPL>, IBufferMessage
	{
		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06007ADA RID: 31450 RVA: 0x00145535 File Offset: 0x00143735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MIMLAKLPCPL> Parser
		{
			get
			{
				return MIMLAKLPCPL._parser;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06007ADB RID: 31451 RVA: 0x0014553C File Offset: 0x0014373C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MIMLAKLPCPLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06007ADC RID: 31452 RVA: 0x0014554E File Offset: 0x0014374E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MIMLAKLPCPL.Descriptor;
			}
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x00145555 File Offset: 0x00143755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MIMLAKLPCPL()
		{
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x00145568 File Offset: 0x00143768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MIMLAKLPCPL(MIMLAKLPCPL other) : this()
		{
			this.rogueMagicScepterInfoList_ = other.rogueMagicScepterInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x00145592 File Offset: 0x00143792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MIMLAKLPCPL Clone()
		{
			return new MIMLAKLPCPL(this);
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x0014559A File Offset: 0x0014379A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JJHOKEMCLGI> RogueMagicScepterInfoList
		{
			get
			{
				return this.rogueMagicScepterInfoList_;
			}
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x001455A2 File Offset: 0x001437A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MIMLAKLPCPL);
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x001455B0 File Offset: 0x001437B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MIMLAKLPCPL other)
		{
			return other != null && (other == this || (this.rogueMagicScepterInfoList_.Equals(other.rogueMagicScepterInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x001455E4 File Offset: 0x001437E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueMagicScepterInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x00145618 File Offset: 0x00143818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x00145620 File Offset: 0x00143820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x00145629 File Offset: 0x00143829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueMagicScepterInfoList_.WriteTo(ref output, MIMLAKLPCPL._repeated_rogueMagicScepterInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x00145650 File Offset: 0x00143850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueMagicScepterInfoList_.CalculateSize(MIMLAKLPCPL._repeated_rogueMagicScepterInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x00145689 File Offset: 0x00143889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MIMLAKLPCPL other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueMagicScepterInfoList_.Add(other.rogueMagicScepterInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x001456B7 File Offset: 0x001438B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x001456C0 File Offset: 0x001438C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueMagicScepterInfoList_.AddEntriesFrom(ref input, MIMLAKLPCPL._repeated_rogueMagicScepterInfoList_codec);
				}
			}
		}

		// Token: 0x04002F25 RID: 12069
		private static readonly MessageParser<MIMLAKLPCPL> _parser = new MessageParser<MIMLAKLPCPL>(() => new MIMLAKLPCPL());

		// Token: 0x04002F26 RID: 12070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F27 RID: 12071
		public const int RogueMagicScepterInfoListFieldNumber = 9;

		// Token: 0x04002F28 RID: 12072
		private static readonly FieldCodec<JJHOKEMCLGI> _repeated_rogueMagicScepterInfoList_codec = FieldCodec.ForMessage<JJHOKEMCLGI>(74U, JJHOKEMCLGI.Parser);

		// Token: 0x04002F29 RID: 12073
		private readonly RepeatedField<JJHOKEMCLGI> rogueMagicScepterInfoList_ = new RepeatedField<JJHOKEMCLGI>();
	}
}
