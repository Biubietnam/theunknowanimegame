using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ADD RID: 2781
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionCustomValueList : IMessage<MissionCustomValueList>, IMessage, IEquatable<MissionCustomValueList>, IDeepCloneable<MissionCustomValueList>, IBufferMessage
	{
		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x00146151 File Offset: 0x00144351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionCustomValueList> Parser
		{
			get
			{
				return MissionCustomValueList._parser;
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06007B33 RID: 31539 RVA: 0x00146158 File Offset: 0x00144358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionCustomValueListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06007B34 RID: 31540 RVA: 0x0014616A File Offset: 0x0014436A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionCustomValueList.Descriptor;
			}
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00146171 File Offset: 0x00144371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValueList()
		{
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x00146184 File Offset: 0x00144384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValueList(MissionCustomValueList other) : this()
		{
			this.customValueList_ = other.customValueList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x001461AE File Offset: 0x001443AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionCustomValueList Clone()
		{
			return new MissionCustomValueList(this);
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06007B38 RID: 31544 RVA: 0x001461B6 File Offset: 0x001443B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MissionCustomValue> CustomValueList
		{
			get
			{
				return this.customValueList_;
			}
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x001461BE File Offset: 0x001443BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionCustomValueList);
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x001461CC File Offset: 0x001443CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionCustomValueList other)
		{
			return other != null && (other == this || (this.customValueList_.Equals(other.customValueList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x00146200 File Offset: 0x00144400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.customValueList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x00146234 File Offset: 0x00144434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x0014623C File Offset: 0x0014443C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x00146245 File Offset: 0x00144445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.customValueList_.WriteTo(ref output, MissionCustomValueList._repeated_customValueList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x0014626C File Offset: 0x0014446C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.customValueList_.CalculateSize(MissionCustomValueList._repeated_customValueList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x001462A5 File Offset: 0x001444A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionCustomValueList other)
		{
			if (other == null)
			{
				return;
			}
			this.customValueList_.Add(other.customValueList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x001462D3 File Offset: 0x001444D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x001462DC File Offset: 0x001444DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.customValueList_.AddEntriesFrom(ref input, MissionCustomValueList._repeated_customValueList_codec);
				}
			}
		}

		// Token: 0x04002F41 RID: 12097
		private static readonly MessageParser<MissionCustomValueList> _parser = new MessageParser<MissionCustomValueList>(() => new MissionCustomValueList());

		// Token: 0x04002F42 RID: 12098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F43 RID: 12099
		public const int CustomValueListFieldNumber = 5;

		// Token: 0x04002F44 RID: 12100
		private static readonly FieldCodec<MissionCustomValue> _repeated_customValueList_codec = FieldCodec.ForMessage<MissionCustomValue>(42U, MissionCustomValue.Parser);

		// Token: 0x04002F45 RID: 12101
		private readonly RepeatedField<MissionCustomValue> customValueList_ = new RepeatedField<MissionCustomValue>();
	}
}
