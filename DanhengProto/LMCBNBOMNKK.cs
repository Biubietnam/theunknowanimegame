using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A23 RID: 2595
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LMCBNBOMNKK : IMessage<LMCBNBOMNKK>, IMessage, IEquatable<LMCBNBOMNKK>, IDeepCloneable<LMCBNBOMNKK>, IBufferMessage
	{
		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06007353 RID: 29523 RVA: 0x0013305A File Offset: 0x0013125A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LMCBNBOMNKK> Parser
		{
			get
			{
				return LMCBNBOMNKK._parser;
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06007354 RID: 29524 RVA: 0x00133061 File Offset: 0x00131261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LMCBNBOMNKKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06007355 RID: 29525 RVA: 0x00133073 File Offset: 0x00131273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LMCBNBOMNKK.Descriptor;
			}
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x0013307A File Offset: 0x0013127A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMCBNBOMNKK()
		{
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x00133082 File Offset: 0x00131282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMCBNBOMNKK(LMCBNBOMNKK other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x0013309B File Offset: 0x0013129B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMCBNBOMNKK Clone()
		{
			return new LMCBNBOMNKK(this);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x001330A3 File Offset: 0x001312A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LMCBNBOMNKK);
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x001330B1 File Offset: 0x001312B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LMCBNBOMNKK other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x001330D0 File Offset: 0x001312D0
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

		// Token: 0x0600735C RID: 29532 RVA: 0x001330F6 File Offset: 0x001312F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x001330FE File Offset: 0x001312FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x00133107 File Offset: 0x00131307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x00133120 File Offset: 0x00131320
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

		// Token: 0x06007360 RID: 29536 RVA: 0x00133146 File Offset: 0x00131346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LMCBNBOMNKK other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x00133163 File Offset: 0x00131363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x0013316C File Offset: 0x0013136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C62 RID: 11362
		private static readonly MessageParser<LMCBNBOMNKK> _parser = new MessageParser<LMCBNBOMNKK>(() => new LMCBNBOMNKK());

		// Token: 0x04002C63 RID: 11363
		private UnknownFieldSet _unknownFields;
	}
}
