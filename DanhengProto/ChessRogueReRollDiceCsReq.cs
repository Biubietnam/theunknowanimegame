using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000287 RID: 647
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueReRollDiceCsReq : IMessage<ChessRogueReRollDiceCsReq>, IMessage, IEquatable<ChessRogueReRollDiceCsReq>, IDeepCloneable<ChessRogueReRollDiceCsReq>, IBufferMessage
	{
		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x00052EBC File Offset: 0x000510BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueReRollDiceCsReq> Parser
		{
			get
			{
				return ChessRogueReRollDiceCsReq._parser;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00052EC3 File Offset: 0x000510C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueReRollDiceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x00052ED5 File Offset: 0x000510D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueReRollDiceCsReq.Descriptor;
			}
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00052EDC File Offset: 0x000510DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReRollDiceCsReq()
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00052EE4 File Offset: 0x000510E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReRollDiceCsReq(ChessRogueReRollDiceCsReq other) : this()
		{
			this.oKCOHJJEEAA_ = other.oKCOHJJEEAA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00052F09 File Offset: 0x00051109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReRollDiceCsReq Clone()
		{
			return new ChessRogueReRollDiceCsReq(this);
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00052F11 File Offset: 0x00051111
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x00052F19 File Offset: 0x00051119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKCOHJJEEAA
		{
			get
			{
				return this.oKCOHJJEEAA_;
			}
			set
			{
				this.oKCOHJJEEAA_ = value;
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00052F22 File Offset: 0x00051122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueReRollDiceCsReq);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00052F30 File Offset: 0x00051130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueReRollDiceCsReq other)
		{
			return other != null && (other == this || (this.OKCOHJJEEAA == other.OKCOHJJEEAA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00052F60 File Offset: 0x00051160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OKCOHJJEEAA != 0U)
			{
				num ^= this.OKCOHJJEEAA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00052F9F File Offset: 0x0005119F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00052FA7 File Offset: 0x000511A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00052FB0 File Offset: 0x000511B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OKCOHJJEEAA != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.OKCOHJJEEAA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00052FE4 File Offset: 0x000511E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OKCOHJJEEAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKCOHJJEEAA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00053022 File Offset: 0x00051222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueReRollDiceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OKCOHJJEEAA != 0U)
			{
				this.OKCOHJJEEAA = other.OKCOHJJEEAA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00053053 File Offset: 0x00051253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0005305C File Offset: 0x0005125C
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
					this.OKCOHJJEEAA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly MessageParser<ChessRogueReRollDiceCsReq> _parser = new MessageParser<ChessRogueReRollDiceCsReq>(() => new ChessRogueReRollDiceCsReq());

		// Token: 0x04000C19 RID: 3097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C1A RID: 3098
		public const int OKCOHJJEEAAFieldNumber = 11;

		// Token: 0x04000C1B RID: 3099
		private uint oKCOHJJEEAA_;
	}
}
