using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200074D RID: 1869
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetNpcStatusCsReq : IMessage<GetNpcStatusCsReq>, IMessage, IEquatable<GetNpcStatusCsReq>, IDeepCloneable<GetNpcStatusCsReq>, IBufferMessage
	{
		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06005390 RID: 21392 RVA: 0x000E11F6 File Offset: 0x000DF3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetNpcStatusCsReq> Parser
		{
			get
			{
				return GetNpcStatusCsReq._parser;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06005391 RID: 21393 RVA: 0x000E11FD File Offset: 0x000DF3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetNpcStatusCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x000E120F File Offset: 0x000DF40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetNpcStatusCsReq.Descriptor;
			}
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x000E1216 File Offset: 0x000DF416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcStatusCsReq()
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x000E121E File Offset: 0x000DF41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcStatusCsReq(GetNpcStatusCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x000E1237 File Offset: 0x000DF437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcStatusCsReq Clone()
		{
			return new GetNpcStatusCsReq(this);
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x000E123F File Offset: 0x000DF43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetNpcStatusCsReq);
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x000E124D File Offset: 0x000DF44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetNpcStatusCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x000E126C File Offset: 0x000DF46C
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

		// Token: 0x06005399 RID: 21401 RVA: 0x000E1292 File Offset: 0x000DF492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x000E129A File Offset: 0x000DF49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x000E12A3 File Offset: 0x000DF4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x000E12BC File Offset: 0x000DF4BC
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

		// Token: 0x0600539D RID: 21405 RVA: 0x000E12E2 File Offset: 0x000DF4E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetNpcStatusCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x000E12FF File Offset: 0x000DF4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x000E1308 File Offset: 0x000DF508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020DE RID: 8414
		private static readonly MessageParser<GetNpcStatusCsReq> _parser = new MessageParser<GetNpcStatusCsReq>(() => new GetNpcStatusCsReq());

		// Token: 0x040020DF RID: 8415
		private UnknownFieldSet _unknownFields;
	}
}
