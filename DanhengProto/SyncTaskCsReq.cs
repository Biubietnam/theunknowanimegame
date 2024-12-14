using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A5 RID: 4773
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncTaskCsReq : IMessage<SyncTaskCsReq>, IMessage, IEquatable<SyncTaskCsReq>, IDeepCloneable<SyncTaskCsReq>, IBufferMessage
	{
		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600D4EA RID: 54506 RVA: 0x00238658 File Offset: 0x00236858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncTaskCsReq> Parser
		{
			get
			{
				return SyncTaskCsReq._parser;
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600D4EB RID: 54507 RVA: 0x0023865F File Offset: 0x0023685F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncTaskCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600D4EC RID: 54508 RVA: 0x00238671 File Offset: 0x00236871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncTaskCsReq.Descriptor;
			}
		}

		// Token: 0x0600D4ED RID: 54509 RVA: 0x00238678 File Offset: 0x00236878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTaskCsReq()
		{
		}

		// Token: 0x0600D4EE RID: 54510 RVA: 0x0023868B File Offset: 0x0023688B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTaskCsReq(SyncTaskCsReq other) : this()
		{
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4EF RID: 54511 RVA: 0x002386B0 File Offset: 0x002368B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTaskCsReq Clone()
		{
			return new SyncTaskCsReq(this);
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600D4F0 RID: 54512 RVA: 0x002386B8 File Offset: 0x002368B8
		// (set) Token: 0x0600D4F1 RID: 54513 RVA: 0x002386C0 File Offset: 0x002368C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x002386D3 File Offset: 0x002368D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncTaskCsReq);
		}

		// Token: 0x0600D4F3 RID: 54515 RVA: 0x002386E1 File Offset: 0x002368E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncTaskCsReq other)
		{
			return other != null && (other == this || (!(this.Key != other.Key) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4F4 RID: 54516 RVA: 0x00238714 File Offset: 0x00236914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4F5 RID: 54517 RVA: 0x00238755 File Offset: 0x00236955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D4F6 RID: 54518 RVA: 0x0023875D File Offset: 0x0023695D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4F7 RID: 54519 RVA: 0x00238766 File Offset: 0x00236966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Key);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4F8 RID: 54520 RVA: 0x002387A0 File Offset: 0x002369A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4F9 RID: 54521 RVA: 0x002387E3 File Offset: 0x002369E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncTaskCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4FA RID: 54522 RVA: 0x00238819 File Offset: 0x00236A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4FB RID: 54523 RVA: 0x00238824 File Offset: 0x00236A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Key = input.ReadString();
				}
			}
		}

		// Token: 0x04005526 RID: 21798
		private static readonly MessageParser<SyncTaskCsReq> _parser = new MessageParser<SyncTaskCsReq>(() => new SyncTaskCsReq());

		// Token: 0x04005527 RID: 21799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005528 RID: 21800
		public const int KeyFieldNumber = 12;

		// Token: 0x04005529 RID: 21801
		private string key_ = "";
	}
}
