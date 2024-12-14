using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200026F RID: 623
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryAeonInfo : IMessage<ChessRogueQueryAeonInfo>, IMessage, IEquatable<ChessRogueQueryAeonInfo>, IDeepCloneable<ChessRogueQueryAeonInfo>, IBufferMessage
	{
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x0004FD39 File Offset: 0x0004DF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryAeonInfo> Parser
		{
			get
			{
				return ChessRogueQueryAeonInfo._parser;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0004FD40 File Offset: 0x0004DF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryAeonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x0004FD52 File Offset: 0x0004DF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryAeonInfo.Descriptor;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0004FD59 File Offset: 0x0004DF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonInfo()
		{
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0004FD6C File Offset: 0x0004DF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonInfo(ChessRogueQueryAeonInfo other) : this()
		{
			this.aeonList_ = other.aeonList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0004FD96 File Offset: 0x0004DF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonInfo Clone()
		{
			return new ChessRogueQueryAeonInfo(this);
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0004FD9E File Offset: 0x0004DF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueQueryAeon> AeonList
		{
			get
			{
				return this.aeonList_;
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0004FDA6 File Offset: 0x0004DFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryAeonInfo);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0004FDB4 File Offset: 0x0004DFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryAeonInfo other)
		{
			return other != null && (other == this || (this.aeonList_.Equals(other.aeonList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0004FDE8 File Offset: 0x0004DFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aeonList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0004FE1C File Offset: 0x0004E01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0004FE24 File Offset: 0x0004E024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0004FE2D File Offset: 0x0004E02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aeonList_.WriteTo(ref output, ChessRogueQueryAeonInfo._repeated_aeonList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0004FE54 File Offset: 0x0004E054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aeonList_.CalculateSize(ChessRogueQueryAeonInfo._repeated_aeonList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0004FE8D File Offset: 0x0004E08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryAeonInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.aeonList_.Add(other.aeonList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0004FEBB File Offset: 0x0004E0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0004FEC4 File Offset: 0x0004E0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aeonList_.AddEntriesFrom(ref input, ChessRogueQueryAeonInfo._repeated_aeonList_codec);
				}
			}
		}

		// Token: 0x04000BA8 RID: 2984
		private static readonly MessageParser<ChessRogueQueryAeonInfo> _parser = new MessageParser<ChessRogueQueryAeonInfo>(() => new ChessRogueQueryAeonInfo());

		// Token: 0x04000BA9 RID: 2985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BAA RID: 2986
		public const int AeonListFieldNumber = 6;

		// Token: 0x04000BAB RID: 2987
		private static readonly FieldCodec<ChessRogueQueryAeon> _repeated_aeonList_codec = FieldCodec.ForMessage<ChessRogueQueryAeon>(50U, ChessRogueQueryAeon.Parser);

		// Token: 0x04000BAC RID: 2988
		private readonly RepeatedField<ChessRogueQueryAeon> aeonList_ = new RepeatedField<ChessRogueQueryAeon>();
	}
}
