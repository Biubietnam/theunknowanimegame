using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200134D RID: 4941
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TelevisionActivityDataChangeScNotify : IMessage<TelevisionActivityDataChangeScNotify>, IMessage, IEquatable<TelevisionActivityDataChangeScNotify>, IDeepCloneable<TelevisionActivityDataChangeScNotify>, IBufferMessage
	{
		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x0600DC88 RID: 56456 RVA: 0x0024B3FB File Offset: 0x002495FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TelevisionActivityDataChangeScNotify> Parser
		{
			get
			{
				return TelevisionActivityDataChangeScNotify._parser;
			}
		}

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x0600DC89 RID: 56457 RVA: 0x0024B402 File Offset: 0x00249602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelevisionActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x0600DC8A RID: 56458 RVA: 0x0024B414 File Offset: 0x00249614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TelevisionActivityDataChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600DC8B RID: 56459 RVA: 0x0024B41B File Offset: 0x0024961B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityDataChangeScNotify()
		{
		}

		// Token: 0x0600DC8C RID: 56460 RVA: 0x0024B42E File Offset: 0x0024962E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityDataChangeScNotify(TelevisionActivityDataChangeScNotify other) : this()
		{
			this.lPEAPMPCFBD_ = other.lPEAPMPCFBD_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC8D RID: 56461 RVA: 0x0024B458 File Offset: 0x00249658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityDataChangeScNotify Clone()
		{
			return new TelevisionActivityDataChangeScNotify(this);
		}

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x0600DC8E RID: 56462 RVA: 0x0024B460 File Offset: 0x00249660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TelevisionActivityData> LPEAPMPCFBD
		{
			get
			{
				return this.lPEAPMPCFBD_;
			}
		}

		// Token: 0x0600DC8F RID: 56463 RVA: 0x0024B468 File Offset: 0x00249668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TelevisionActivityDataChangeScNotify);
		}

		// Token: 0x0600DC90 RID: 56464 RVA: 0x0024B476 File Offset: 0x00249676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TelevisionActivityDataChangeScNotify other)
		{
			return other != null && (other == this || (this.lPEAPMPCFBD_.Equals(other.lPEAPMPCFBD_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC91 RID: 56465 RVA: 0x0024B4AC File Offset: 0x002496AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.lPEAPMPCFBD_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC92 RID: 56466 RVA: 0x0024B4E0 File Offset: 0x002496E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DC93 RID: 56467 RVA: 0x0024B4E8 File Offset: 0x002496E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC94 RID: 56468 RVA: 0x0024B4F1 File Offset: 0x002496F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lPEAPMPCFBD_.WriteTo(ref output, TelevisionActivityDataChangeScNotify._repeated_lPEAPMPCFBD_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC95 RID: 56469 RVA: 0x0024B518 File Offset: 0x00249718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lPEAPMPCFBD_.CalculateSize(TelevisionActivityDataChangeScNotify._repeated_lPEAPMPCFBD_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC96 RID: 56470 RVA: 0x0024B551 File Offset: 0x00249751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TelevisionActivityDataChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.lPEAPMPCFBD_.Add(other.lPEAPMPCFBD_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC97 RID: 56471 RVA: 0x0024B57F File Offset: 0x0024977F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC98 RID: 56472 RVA: 0x0024B588 File Offset: 0x00249788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.lPEAPMPCFBD_.AddEntriesFrom(ref input, TelevisionActivityDataChangeScNotify._repeated_lPEAPMPCFBD_codec);
				}
			}
		}

		// Token: 0x040057BC RID: 22460
		private static readonly MessageParser<TelevisionActivityDataChangeScNotify> _parser = new MessageParser<TelevisionActivityDataChangeScNotify>(() => new TelevisionActivityDataChangeScNotify());

		// Token: 0x040057BD RID: 22461
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057BE RID: 22462
		public const int LPEAPMPCFBDFieldNumber = 13;

		// Token: 0x040057BF RID: 22463
		private static readonly FieldCodec<TelevisionActivityData> _repeated_lPEAPMPCFBD_codec = FieldCodec.ForMessage<TelevisionActivityData>(106U, TelevisionActivityData.Parser);

		// Token: 0x040057C0 RID: 22464
		private readonly RepeatedField<TelevisionActivityData> lPEAPMPCFBD_ = new RepeatedField<TelevisionActivityData>();
	}
}
