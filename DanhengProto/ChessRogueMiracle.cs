using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000243 RID: 579
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueMiracle : IMessage<ChessRogueMiracle>, IMessage, IEquatable<ChessRogueMiracle>, IDeepCloneable<ChessRogueMiracle>, IBufferMessage
	{
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x0004BD6D File Offset: 0x00049F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueMiracle> Parser
		{
			get
			{
				return ChessRogueMiracle._parser;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x0004BD74 File Offset: 0x00049F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueMiracleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x0004BD86 File Offset: 0x00049F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueMiracle.Descriptor;
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0004BD8D File Offset: 0x00049F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracle()
		{
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0004BDA0 File Offset: 0x00049FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracle(ChessRogueMiracle other) : this()
		{
			this.miracleList_ = other.miracleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0004BDCA File Offset: 0x00049FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracle Clone()
		{
			return new ChessRogueMiracle(this);
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0004BDD2 File Offset: 0x00049FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameRogueMiracle> MiracleList
		{
			get
			{
				return this.miracleList_;
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0004BDDA File Offset: 0x00049FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueMiracle);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0004BDE8 File Offset: 0x00049FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueMiracle other)
		{
			return other != null && (other == this || (this.miracleList_.Equals(other.miracleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0004BE1C File Offset: 0x0004A01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.miracleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0004BE50 File Offset: 0x0004A050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0004BE58 File Offset: 0x0004A058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0004BE61 File Offset: 0x0004A061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.miracleList_.WriteTo(ref output, ChessRogueMiracle._repeated_miracleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0004BE88 File Offset: 0x0004A088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.miracleList_.CalculateSize(ChessRogueMiracle._repeated_miracleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0004BEC1 File Offset: 0x0004A0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueMiracle other)
		{
			if (other == null)
			{
				return;
			}
			this.miracleList_.Add(other.miracleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0004BEEF File Offset: 0x0004A0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0004BEF8 File Offset: 0x0004A0F8
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
					this.miracleList_.AddEntriesFrom(ref input, ChessRogueMiracle._repeated_miracleList_codec);
				}
			}
		}

		// Token: 0x04000B1B RID: 2843
		private static readonly MessageParser<ChessRogueMiracle> _parser = new MessageParser<ChessRogueMiracle>(() => new ChessRogueMiracle());

		// Token: 0x04000B1C RID: 2844
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B1D RID: 2845
		public const int MiracleListFieldNumber = 9;

		// Token: 0x04000B1E RID: 2846
		private static readonly FieldCodec<GameRogueMiracle> _repeated_miracleList_codec = FieldCodec.ForMessage<GameRogueMiracle>(74U, GameRogueMiracle.Parser);

		// Token: 0x04000B1F RID: 2847
		private readonly RepeatedField<GameRogueMiracle> miracleList_ = new RepeatedField<GameRogueMiracle>();
	}
}
