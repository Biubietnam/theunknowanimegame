using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001231 RID: 4657
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingGiveUpGameCsReq : IMessage<SwordTrainingGiveUpGameCsReq>, IMessage, IEquatable<SwordTrainingGiveUpGameCsReq>, IDeepCloneable<SwordTrainingGiveUpGameCsReq>, IBufferMessage
	{
		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0600D00D RID: 53261 RVA: 0x0022D6CB File Offset: 0x0022B8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingGiveUpGameCsReq> Parser
		{
			get
			{
				return SwordTrainingGiveUpGameCsReq._parser;
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0600D00E RID: 53262 RVA: 0x0022D6D2 File Offset: 0x0022B8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingGiveUpGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0600D00F RID: 53263 RVA: 0x0022D6E4 File Offset: 0x0022B8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingGiveUpGameCsReq.Descriptor;
			}
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x0022D6EB File Offset: 0x0022B8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGiveUpGameCsReq()
		{
		}

		// Token: 0x0600D011 RID: 53265 RVA: 0x0022D6F3 File Offset: 0x0022B8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGiveUpGameCsReq(SwordTrainingGiveUpGameCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D012 RID: 53266 RVA: 0x0022D70C File Offset: 0x0022B90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGiveUpGameCsReq Clone()
		{
			return new SwordTrainingGiveUpGameCsReq(this);
		}

		// Token: 0x0600D013 RID: 53267 RVA: 0x0022D714 File Offset: 0x0022B914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingGiveUpGameCsReq);
		}

		// Token: 0x0600D014 RID: 53268 RVA: 0x0022D722 File Offset: 0x0022B922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingGiveUpGameCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D015 RID: 53269 RVA: 0x0022D740 File Offset: 0x0022B940
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

		// Token: 0x0600D016 RID: 53270 RVA: 0x0022D766 File Offset: 0x0022B966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D017 RID: 53271 RVA: 0x0022D76E File Offset: 0x0022B96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D018 RID: 53272 RVA: 0x0022D777 File Offset: 0x0022B977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D019 RID: 53273 RVA: 0x0022D790 File Offset: 0x0022B990
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

		// Token: 0x0600D01A RID: 53274 RVA: 0x0022D7B6 File Offset: 0x0022B9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingGiveUpGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D01B RID: 53275 RVA: 0x0022D7D3 File Offset: 0x0022B9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D01C RID: 53276 RVA: 0x0022D7DC File Offset: 0x0022B9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040053B0 RID: 21424
		private static readonly MessageParser<SwordTrainingGiveUpGameCsReq> _parser = new MessageParser<SwordTrainingGiveUpGameCsReq>(() => new SwordTrainingGiveUpGameCsReq());

		// Token: 0x040053B1 RID: 21425
		private UnknownFieldSet _unknownFields;
	}
}
