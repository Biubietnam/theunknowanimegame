using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004AB RID: 1195
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildLeaveCsReq : IMessage<EvolveBuildLeaveCsReq>, IMessage, IEquatable<EvolveBuildLeaveCsReq>, IDeepCloneable<EvolveBuildLeaveCsReq>, IBufferMessage
	{
		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x0600356B RID: 13675 RVA: 0x000932DF File Offset: 0x000914DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildLeaveCsReq> Parser
		{
			get
			{
				return EvolveBuildLeaveCsReq._parser;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x000932E6 File Offset: 0x000914E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildLeaveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x0600356D RID: 13677 RVA: 0x000932F8 File Offset: 0x000914F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildLeaveCsReq.Descriptor;
			}
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x000932FF File Offset: 0x000914FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLeaveCsReq()
		{
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00093307 File Offset: 0x00091507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLeaveCsReq(EvolveBuildLeaveCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00093320 File Offset: 0x00091520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLeaveCsReq Clone()
		{
			return new EvolveBuildLeaveCsReq(this);
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00093328 File Offset: 0x00091528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildLeaveCsReq);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00093336 File Offset: 0x00091536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildLeaveCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00093354 File Offset: 0x00091554
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

		// Token: 0x06003574 RID: 13684 RVA: 0x0009337A File Offset: 0x0009157A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x00093382 File Offset: 0x00091582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x0009338B File Offset: 0x0009158B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x000933A4 File Offset: 0x000915A4
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

		// Token: 0x06003578 RID: 13688 RVA: 0x000933CA File Offset: 0x000915CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildLeaveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x000933E7 File Offset: 0x000915E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x000933F0 File Offset: 0x000915F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001550 RID: 5456
		private static readonly MessageParser<EvolveBuildLeaveCsReq> _parser = new MessageParser<EvolveBuildLeaveCsReq>(() => new EvolveBuildLeaveCsReq());

		// Token: 0x04001551 RID: 5457
		private UnknownFieldSet _unknownFields;
	}
}
