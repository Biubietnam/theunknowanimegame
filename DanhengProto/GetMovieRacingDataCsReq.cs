using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000739 RID: 1849
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMovieRacingDataCsReq : IMessage<GetMovieRacingDataCsReq>, IMessage, IEquatable<GetMovieRacingDataCsReq>, IDeepCloneable<GetMovieRacingDataCsReq>, IBufferMessage
	{
		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x060052AA RID: 21162 RVA: 0x000DEBDF File Offset: 0x000DCDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMovieRacingDataCsReq> Parser
		{
			get
			{
				return GetMovieRacingDataCsReq._parser;
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x000DEBE6 File Offset: 0x000DCDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMovieRacingDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x000DEBF8 File Offset: 0x000DCDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMovieRacingDataCsReq.Descriptor;
			}
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x000DEBFF File Offset: 0x000DCDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMovieRacingDataCsReq()
		{
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x000DEC07 File Offset: 0x000DCE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMovieRacingDataCsReq(GetMovieRacingDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x000DEC20 File Offset: 0x000DCE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMovieRacingDataCsReq Clone()
		{
			return new GetMovieRacingDataCsReq(this);
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x000DEC28 File Offset: 0x000DCE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMovieRacingDataCsReq);
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x000DEC36 File Offset: 0x000DCE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMovieRacingDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x000DEC54 File Offset: 0x000DCE54
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

		// Token: 0x060052B3 RID: 21171 RVA: 0x000DEC7A File Offset: 0x000DCE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x000DEC82 File Offset: 0x000DCE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x000DEC8B File Offset: 0x000DCE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x000DECA4 File Offset: 0x000DCEA4
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

		// Token: 0x060052B7 RID: 21175 RVA: 0x000DECCA File Offset: 0x000DCECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMovieRacingDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x000DECE7 File Offset: 0x000DCEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x000DECF0 File Offset: 0x000DCEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002080 RID: 8320
		private static readonly MessageParser<GetMovieRacingDataCsReq> _parser = new MessageParser<GetMovieRacingDataCsReq>(() => new GetMovieRacingDataCsReq());

		// Token: 0x04002081 RID: 8321
		private UnknownFieldSet _unknownFields;
	}
}
