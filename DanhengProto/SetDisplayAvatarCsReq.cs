using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010E9 RID: 4329
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetDisplayAvatarCsReq : IMessage<SetDisplayAvatarCsReq>, IMessage, IEquatable<SetDisplayAvatarCsReq>, IDeepCloneable<SetDisplayAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600C104 RID: 49412 RVA: 0x00207051 File Offset: 0x00205251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetDisplayAvatarCsReq> Parser
		{
			get
			{
				return SetDisplayAvatarCsReq._parser;
			}
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600C105 RID: 49413 RVA: 0x00207058 File Offset: 0x00205258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetDisplayAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600C106 RID: 49414 RVA: 0x0020706A File Offset: 0x0020526A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetDisplayAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x0600C107 RID: 49415 RVA: 0x00207071 File Offset: 0x00205271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetDisplayAvatarCsReq()
		{
		}

		// Token: 0x0600C108 RID: 49416 RVA: 0x00207084 File Offset: 0x00205284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetDisplayAvatarCsReq(SetDisplayAvatarCsReq other) : this()
		{
			this.displayAvatarList_ = other.displayAvatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C109 RID: 49417 RVA: 0x002070AE File Offset: 0x002052AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetDisplayAvatarCsReq Clone()
		{
			return new SetDisplayAvatarCsReq(this);
		}

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0600C10A RID: 49418 RVA: 0x002070B6 File Offset: 0x002052B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DisplayAvatarData> DisplayAvatarList
		{
			get
			{
				return this.displayAvatarList_;
			}
		}

		// Token: 0x0600C10B RID: 49419 RVA: 0x002070BE File Offset: 0x002052BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetDisplayAvatarCsReq);
		}

		// Token: 0x0600C10C RID: 49420 RVA: 0x002070CC File Offset: 0x002052CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetDisplayAvatarCsReq other)
		{
			return other != null && (other == this || (this.displayAvatarList_.Equals(other.displayAvatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C10D RID: 49421 RVA: 0x00207100 File Offset: 0x00205300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.displayAvatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C10E RID: 49422 RVA: 0x00207134 File Offset: 0x00205334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C10F RID: 49423 RVA: 0x0020713C File Offset: 0x0020533C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C110 RID: 49424 RVA: 0x00207145 File Offset: 0x00205345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.displayAvatarList_.WriteTo(ref output, SetDisplayAvatarCsReq._repeated_displayAvatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C111 RID: 49425 RVA: 0x0020716C File Offset: 0x0020536C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.displayAvatarList_.CalculateSize(SetDisplayAvatarCsReq._repeated_displayAvatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C112 RID: 49426 RVA: 0x002071A5 File Offset: 0x002053A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetDisplayAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.displayAvatarList_.Add(other.displayAvatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C113 RID: 49427 RVA: 0x002071D3 File Offset: 0x002053D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C114 RID: 49428 RVA: 0x002071DC File Offset: 0x002053DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.displayAvatarList_.AddEntriesFrom(ref input, SetDisplayAvatarCsReq._repeated_displayAvatarList_codec);
				}
			}
		}

		// Token: 0x04004E33 RID: 20019
		private static readonly MessageParser<SetDisplayAvatarCsReq> _parser = new MessageParser<SetDisplayAvatarCsReq>(() => new SetDisplayAvatarCsReq());

		// Token: 0x04004E34 RID: 20020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E35 RID: 20021
		public const int DisplayAvatarListFieldNumber = 10;

		// Token: 0x04004E36 RID: 20022
		private static readonly FieldCodec<DisplayAvatarData> _repeated_displayAvatarList_codec = FieldCodec.ForMessage<DisplayAvatarData>(82U, DisplayAvatarData.Parser);

		// Token: 0x04004E37 RID: 20023
		private readonly RepeatedField<DisplayAvatarData> displayAvatarList_ = new RepeatedField<DisplayAvatarData>();
	}
}
