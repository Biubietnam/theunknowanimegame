using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A9D RID: 2717
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchThreeGetDataCsReq : IMessage<MatchThreeGetDataCsReq>, IMessage, IEquatable<MatchThreeGetDataCsReq>, IDeepCloneable<MatchThreeGetDataCsReq>, IBufferMessage
	{
		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06007864 RID: 30820 RVA: 0x0013F247 File Offset: 0x0013D447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeGetDataCsReq> Parser
		{
			get
			{
				return MatchThreeGetDataCsReq._parser;
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06007865 RID: 30821 RVA: 0x0013F24E File Offset: 0x0013D44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchThreeGetDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06007866 RID: 30822 RVA: 0x0013F260 File Offset: 0x0013D460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeGetDataCsReq.Descriptor;
			}
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x0013F267 File Offset: 0x0013D467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeGetDataCsReq()
		{
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x0013F26F File Offset: 0x0013D46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeGetDataCsReq(MatchThreeGetDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x0013F288 File Offset: 0x0013D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeGetDataCsReq Clone()
		{
			return new MatchThreeGetDataCsReq(this);
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x0013F290 File Offset: 0x0013D490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeGetDataCsReq);
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x0013F29E File Offset: 0x0013D49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeGetDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x0013F2BC File Offset: 0x0013D4BC
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

		// Token: 0x0600786D RID: 30829 RVA: 0x0013F2E2 File Offset: 0x0013D4E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x0013F2EA File Offset: 0x0013D4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x0013F2F3 File Offset: 0x0013D4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x0013F30C File Offset: 0x0013D50C
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

		// Token: 0x06007871 RID: 30833 RVA: 0x0013F332 File Offset: 0x0013D532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeGetDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x0013F34F File Offset: 0x0013D54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x0013F358 File Offset: 0x0013D558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E3B RID: 11835
		private static readonly MessageParser<MatchThreeGetDataCsReq> _parser = new MessageParser<MatchThreeGetDataCsReq>(() => new MatchThreeGetDataCsReq());

		// Token: 0x04002E3C RID: 11836
		private UnknownFieldSet _unknownFields;
	}
}
