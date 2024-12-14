using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200043F RID: 1087
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnteredSceneChangeScNotify : IMessage<EnteredSceneChangeScNotify>, IMessage, IEquatable<EnteredSceneChangeScNotify>, IDeepCloneable<EnteredSceneChangeScNotify>, IBufferMessage
	{
		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x00084951 File Offset: 0x00082B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnteredSceneChangeScNotify> Parser
		{
			get
			{
				return EnteredSceneChangeScNotify._parser;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x00084958 File Offset: 0x00082B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnteredSceneChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x0008496A File Offset: 0x00082B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnteredSceneChangeScNotify.Descriptor;
			}
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x00084971 File Offset: 0x00082B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnteredSceneChangeScNotify()
		{
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x00084984 File Offset: 0x00082B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnteredSceneChangeScNotify(EnteredSceneChangeScNotify other) : this()
		{
			this.enteredSceneInfoList_ = other.enteredSceneInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000849AE File Offset: 0x00082BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnteredSceneChangeScNotify Clone()
		{
			return new EnteredSceneChangeScNotify(this);
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x000849B6 File Offset: 0x00082BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnteredSceneInfo> EnteredSceneInfoList
		{
			get
			{
				return this.enteredSceneInfoList_;
			}
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x000849BE File Offset: 0x00082BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnteredSceneChangeScNotify);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x000849CC File Offset: 0x00082BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnteredSceneChangeScNotify other)
		{
			return other != null && (other == this || (this.enteredSceneInfoList_.Equals(other.enteredSceneInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x00084A00 File Offset: 0x00082C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.enteredSceneInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x00084A34 File Offset: 0x00082C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x00084A3C File Offset: 0x00082C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x00084A45 File Offset: 0x00082C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enteredSceneInfoList_.WriteTo(ref output, EnteredSceneChangeScNotify._repeated_enteredSceneInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x00084A6C File Offset: 0x00082C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.enteredSceneInfoList_.CalculateSize(EnteredSceneChangeScNotify._repeated_enteredSceneInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00084AA5 File Offset: 0x00082CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnteredSceneChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.enteredSceneInfoList_.Add(other.enteredSceneInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x00084AD3 File Offset: 0x00082CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00084ADC File Offset: 0x00082CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.enteredSceneInfoList_.AddEntriesFrom(ref input, EnteredSceneChangeScNotify._repeated_enteredSceneInfoList_codec);
				}
			}
		}

		// Token: 0x04001333 RID: 4915
		private static readonly MessageParser<EnteredSceneChangeScNotify> _parser = new MessageParser<EnteredSceneChangeScNotify>(() => new EnteredSceneChangeScNotify());

		// Token: 0x04001334 RID: 4916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001335 RID: 4917
		public const int EnteredSceneInfoListFieldNumber = 1;

		// Token: 0x04001336 RID: 4918
		private static readonly FieldCodec<EnteredSceneInfo> _repeated_enteredSceneInfoList_codec = FieldCodec.ForMessage<EnteredSceneInfo>(10U, EnteredSceneInfo.Parser);

		// Token: 0x04001337 RID: 4919
		private readonly RepeatedField<EnteredSceneInfo> enteredSceneInfoList_ = new RepeatedField<EnteredSceneInfo>();
	}
}
