using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009D9 RID: 2521
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LAGHMBLEMJJ : IMessage<LAGHMBLEMJJ>, IMessage, IEquatable<LAGHMBLEMJJ>, IDeepCloneable<LAGHMBLEMJJ>, IBufferMessage
	{
		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06007031 RID: 28721 RVA: 0x0012B5A1 File Offset: 0x001297A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LAGHMBLEMJJ> Parser
		{
			get
			{
				return LAGHMBLEMJJ._parser;
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06007032 RID: 28722 RVA: 0x0012B5A8 File Offset: 0x001297A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LAGHMBLEMJJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x0012B5BA File Offset: 0x001297BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LAGHMBLEMJJ.Descriptor;
			}
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x0012B5C1 File Offset: 0x001297C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAGHMBLEMJJ()
		{
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x0012B5D4 File Offset: 0x001297D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAGHMBLEMJJ(LAGHMBLEMJJ other) : this()
		{
			this.rogueMagicUnitInfoList_ = other.rogueMagicUnitInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x0012B5FE File Offset: 0x001297FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAGHMBLEMJJ Clone()
		{
			return new LAGHMBLEMJJ(this);
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06007037 RID: 28727 RVA: 0x0012B606 File Offset: 0x00129806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DDBGPHLEGIC> RogueMagicUnitInfoList
		{
			get
			{
				return this.rogueMagicUnitInfoList_;
			}
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x0012B60E File Offset: 0x0012980E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LAGHMBLEMJJ);
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x0012B61C File Offset: 0x0012981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LAGHMBLEMJJ other)
		{
			return other != null && (other == this || (this.rogueMagicUnitInfoList_.Equals(other.rogueMagicUnitInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x0012B650 File Offset: 0x00129850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueMagicUnitInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x0012B684 File Offset: 0x00129884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x0012B68C File Offset: 0x0012988C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x0012B695 File Offset: 0x00129895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueMagicUnitInfoList_.WriteTo(ref output, LAGHMBLEMJJ._repeated_rogueMagicUnitInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x0012B6BC File Offset: 0x001298BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueMagicUnitInfoList_.CalculateSize(LAGHMBLEMJJ._repeated_rogueMagicUnitInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x0012B6F5 File Offset: 0x001298F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LAGHMBLEMJJ other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueMagicUnitInfoList_.Add(other.rogueMagicUnitInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x0012B723 File Offset: 0x00129923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x0012B72C File Offset: 0x0012992C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueMagicUnitInfoList_.AddEntriesFrom(ref input, LAGHMBLEMJJ._repeated_rogueMagicUnitInfoList_codec);
				}
			}
		}

		// Token: 0x04002B32 RID: 11058
		private static readonly MessageParser<LAGHMBLEMJJ> _parser = new MessageParser<LAGHMBLEMJJ>(() => new LAGHMBLEMJJ());

		// Token: 0x04002B33 RID: 11059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B34 RID: 11060
		public const int RogueMagicUnitInfoListFieldNumber = 12;

		// Token: 0x04002B35 RID: 11061
		private static readonly FieldCodec<DDBGPHLEGIC> _repeated_rogueMagicUnitInfoList_codec = FieldCodec.ForMessage<DDBGPHLEGIC>(98U, DDBGPHLEGIC.Parser);

		// Token: 0x04002B36 RID: 11062
		private readonly RepeatedField<DDBGPHLEGIC> rogueMagicUnitInfoList_ = new RepeatedField<DDBGPHLEGIC>();
	}
}
