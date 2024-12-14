using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000263 RID: 611
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousValueInfo : IMessage<ChessRogueNousValueInfo>, IMessage, IEquatable<ChessRogueNousValueInfo>, IDeepCloneable<ChessRogueNousValueInfo>, IBufferMessage
	{
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0004EA6C File Offset: 0x0004CC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousValueInfo> Parser
		{
			get
			{
				return ChessRogueNousValueInfo._parser;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0004EA73 File Offset: 0x0004CC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousValueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x0004EA85 File Offset: 0x0004CC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousValueInfo.Descriptor;
			}
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0004EA8C File Offset: 0x0004CC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousValueInfo()
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0004EA94 File Offset: 0x0004CC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousValueInfo(ChessRogueNousValueInfo other) : this()
		{
			this.nousValue_ = other.nousValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0004EAB9 File Offset: 0x0004CCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousValueInfo Clone()
		{
			return new ChessRogueNousValueInfo(this);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x0004EAC1 File Offset: 0x0004CCC1
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x0004EAC9 File Offset: 0x0004CCC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NousValue
		{
			get
			{
				return this.nousValue_;
			}
			set
			{
				this.nousValue_ = value;
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0004EAD2 File Offset: 0x0004CCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousValueInfo);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0004EAE0 File Offset: 0x0004CCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousValueInfo other)
		{
			return other != null && (other == this || (this.NousValue == other.NousValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0004EB10 File Offset: 0x0004CD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NousValue != 0)
			{
				num ^= this.NousValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0004EB4F File Offset: 0x0004CD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0004EB57 File Offset: 0x0004CD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0004EB60 File Offset: 0x0004CD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NousValue != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.NousValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0004EB94 File Offset: 0x0004CD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NousValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NousValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0004EBD2 File Offset: 0x0004CDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousValueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NousValue != 0)
			{
				this.NousValue = other.NousValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0004EC03 File Offset: 0x0004CE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0004EC0C File Offset: 0x0004CE0C
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
					this.NousValue = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000B80 RID: 2944
		private static readonly MessageParser<ChessRogueNousValueInfo> _parser = new MessageParser<ChessRogueNousValueInfo>(() => new ChessRogueNousValueInfo());

		// Token: 0x04000B81 RID: 2945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B82 RID: 2946
		public const int NousValueFieldNumber = 11;

		// Token: 0x04000B83 RID: 2947
		private int nousValue_;
	}
}
