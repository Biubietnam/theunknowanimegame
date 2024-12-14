using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E1D RID: 3613
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffInfo : IMessage<RogueBuffInfo>, IMessage, IEquatable<RogueBuffInfo>, IDeepCloneable<RogueBuffInfo>, IBufferMessage
	{
		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0600A15C RID: 41308 RVA: 0x001B09C0 File Offset: 0x001AEBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffInfo> Parser
		{
			get
			{
				return RogueBuffInfo._parser;
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0600A15D RID: 41309 RVA: 0x001B09C7 File Offset: 0x001AEBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0600A15E RID: 41310 RVA: 0x001B09D9 File Offset: 0x001AEBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffInfo.Descriptor;
			}
		}

		// Token: 0x0600A15F RID: 41311 RVA: 0x001B09E0 File Offset: 0x001AEBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffInfo()
		{
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x001B09F3 File Offset: 0x001AEBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffInfo(RogueBuffInfo other) : this()
		{
			this.mazeBuffList_ = other.mazeBuffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x001B0A1D File Offset: 0x001AEC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffInfo Clone()
		{
			return new RogueBuffInfo(this);
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0600A162 RID: 41314 RVA: 0x001B0A25 File Offset: 0x001AEC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueBuff> MazeBuffList
		{
			get
			{
				return this.mazeBuffList_;
			}
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x001B0A2D File Offset: 0x001AEC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffInfo);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x001B0A3B File Offset: 0x001AEC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffInfo other)
		{
			return other != null && (other == this || (this.mazeBuffList_.Equals(other.mazeBuffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x001B0A70 File Offset: 0x001AEC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mazeBuffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x001B0AA4 File Offset: 0x001AECA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x001B0AAC File Offset: 0x001AECAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x001B0AB5 File Offset: 0x001AECB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mazeBuffList_.WriteTo(ref output, RogueBuffInfo._repeated_mazeBuffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x001B0ADC File Offset: 0x001AECDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mazeBuffList_.CalculateSize(RogueBuffInfo._repeated_mazeBuffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x001B0B15 File Offset: 0x001AED15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.mazeBuffList_.Add(other.mazeBuffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x001B0B43 File Offset: 0x001AED43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x001B0B4C File Offset: 0x001AED4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mazeBuffList_.AddEntriesFrom(ref input, RogueBuffInfo._repeated_mazeBuffList_codec);
				}
			}
		}

		// Token: 0x0400420C RID: 16908
		private static readonly MessageParser<RogueBuffInfo> _parser = new MessageParser<RogueBuffInfo>(() => new RogueBuffInfo());

		// Token: 0x0400420D RID: 16909
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400420E RID: 16910
		public const int MazeBuffListFieldNumber = 15;

		// Token: 0x0400420F RID: 16911
		private static readonly FieldCodec<RogueBuff> _repeated_mazeBuffList_codec = FieldCodec.ForMessage<RogueBuff>(122U, RogueBuff.Parser);

		// Token: 0x04004210 RID: 16912
		private readonly RepeatedField<RogueBuff> mazeBuffList_ = new RepeatedField<RogueBuff>();
	}
}
