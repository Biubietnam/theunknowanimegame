using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CCB RID: 3275
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerLogoutCsReq : IMessage<PlayerLogoutCsReq>, IMessage, IEquatable<PlayerLogoutCsReq>, IDeepCloneable<PlayerLogoutCsReq>, IBufferMessage
	{
		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x0600920F RID: 37391 RVA: 0x00183716 File Offset: 0x00181916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerLogoutCsReq> Parser
		{
			get
			{
				return PlayerLogoutCsReq._parser;
			}
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x06009210 RID: 37392 RVA: 0x0018371D File Offset: 0x0018191D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerLogoutCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x06009211 RID: 37393 RVA: 0x0018372F File Offset: 0x0018192F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLogoutCsReq.Descriptor;
			}
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x00183736 File Offset: 0x00181936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLogoutCsReq()
		{
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x0018373E File Offset: 0x0018193E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLogoutCsReq(PlayerLogoutCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x00183757 File Offset: 0x00181957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLogoutCsReq Clone()
		{
			return new PlayerLogoutCsReq(this);
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x0018375F File Offset: 0x0018195F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLogoutCsReq);
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x0018376D File Offset: 0x0018196D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLogoutCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x0018378C File Offset: 0x0018198C
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

		// Token: 0x06009218 RID: 37400 RVA: 0x001837B2 File Offset: 0x001819B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x001837BA File Offset: 0x001819BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x001837C3 File Offset: 0x001819C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x001837DC File Offset: 0x001819DC
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

		// Token: 0x0600921C RID: 37404 RVA: 0x00183802 File Offset: 0x00181A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLogoutCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x0018381F File Offset: 0x00181A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x00183828 File Offset: 0x00181A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400385F RID: 14431
		private static readonly MessageParser<PlayerLogoutCsReq> _parser = new MessageParser<PlayerLogoutCsReq>(() => new PlayerLogoutCsReq());

		// Token: 0x04003860 RID: 14432
		private UnknownFieldSet _unknownFields;
	}
}
