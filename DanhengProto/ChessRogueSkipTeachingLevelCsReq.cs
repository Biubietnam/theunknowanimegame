using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200029B RID: 667
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueSkipTeachingLevelCsReq : IMessage<ChessRogueSkipTeachingLevelCsReq>, IMessage, IEquatable<ChessRogueSkipTeachingLevelCsReq>, IDeepCloneable<ChessRogueSkipTeachingLevelCsReq>, IBufferMessage
	{
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00055257 File Offset: 0x00053457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueSkipTeachingLevelCsReq> Parser
		{
			get
			{
				return ChessRogueSkipTeachingLevelCsReq._parser;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0005525E File Offset: 0x0005345E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueSkipTeachingLevelCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00055270 File Offset: 0x00053470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueSkipTeachingLevelCsReq.Descriptor;
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00055277 File Offset: 0x00053477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSkipTeachingLevelCsReq()
		{
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0005527F File Offset: 0x0005347F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSkipTeachingLevelCsReq(ChessRogueSkipTeachingLevelCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00055298 File Offset: 0x00053498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSkipTeachingLevelCsReq Clone()
		{
			return new ChessRogueSkipTeachingLevelCsReq(this);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x000552A0 File Offset: 0x000534A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueSkipTeachingLevelCsReq);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000552AE File Offset: 0x000534AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueSkipTeachingLevelCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000552CC File Offset: 0x000534CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x000552F2 File Offset: 0x000534F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x000552FA File Offset: 0x000534FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00055303 File Offset: 0x00053503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0005531C File Offset: 0x0005351C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00055342 File Offset: 0x00053542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueSkipTeachingLevelCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0005535F File Offset: 0x0005355F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00055368 File Offset: 0x00053568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C64 RID: 3172
		private static readonly MessageParser<ChessRogueSkipTeachingLevelCsReq> _parser = new MessageParser<ChessRogueSkipTeachingLevelCsReq>(() => new ChessRogueSkipTeachingLevelCsReq());

		// Token: 0x04000C65 RID: 3173
		private UnknownFieldSet _unknownFields;
	}
}
