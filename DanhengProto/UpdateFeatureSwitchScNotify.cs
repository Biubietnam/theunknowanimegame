using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D7 RID: 5079
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateFeatureSwitchScNotify : IMessage<UpdateFeatureSwitchScNotify>, IMessage, IEquatable<UpdateFeatureSwitchScNotify>, IDeepCloneable<UpdateFeatureSwitchScNotify>, IBufferMessage
	{
		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x0600E264 RID: 57956 RVA: 0x0025A165 File Offset: 0x00258365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateFeatureSwitchScNotify> Parser
		{
			get
			{
				return UpdateFeatureSwitchScNotify._parser;
			}
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x0600E265 RID: 57957 RVA: 0x0025A16C File Offset: 0x0025836C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateFeatureSwitchScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x0600E266 RID: 57958 RVA: 0x0025A17E File Offset: 0x0025837E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFeatureSwitchScNotify.Descriptor;
			}
		}

		// Token: 0x0600E267 RID: 57959 RVA: 0x0025A185 File Offset: 0x00258385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFeatureSwitchScNotify()
		{
		}

		// Token: 0x0600E268 RID: 57960 RVA: 0x0025A198 File Offset: 0x00258398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFeatureSwitchScNotify(UpdateFeatureSwitchScNotify other) : this()
		{
			this.switchInfoList_ = other.switchInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E269 RID: 57961 RVA: 0x0025A1C2 File Offset: 0x002583C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFeatureSwitchScNotify Clone()
		{
			return new UpdateFeatureSwitchScNotify(this);
		}

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x0600E26A RID: 57962 RVA: 0x0025A1CA File Offset: 0x002583CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FeatureSwitchInfo> SwitchInfoList
		{
			get
			{
				return this.switchInfoList_;
			}
		}

		// Token: 0x0600E26B RID: 57963 RVA: 0x0025A1D2 File Offset: 0x002583D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFeatureSwitchScNotify);
		}

		// Token: 0x0600E26C RID: 57964 RVA: 0x0025A1E0 File Offset: 0x002583E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFeatureSwitchScNotify other)
		{
			return other != null && (other == this || (this.switchInfoList_.Equals(other.switchInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E26D RID: 57965 RVA: 0x0025A214 File Offset: 0x00258414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.switchInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E26E RID: 57966 RVA: 0x0025A248 File Offset: 0x00258448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E26F RID: 57967 RVA: 0x0025A250 File Offset: 0x00258450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E270 RID: 57968 RVA: 0x0025A259 File Offset: 0x00258459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.switchInfoList_.WriteTo(ref output, UpdateFeatureSwitchScNotify._repeated_switchInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E271 RID: 57969 RVA: 0x0025A280 File Offset: 0x00258480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.switchInfoList_.CalculateSize(UpdateFeatureSwitchScNotify._repeated_switchInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E272 RID: 57970 RVA: 0x0025A2B9 File Offset: 0x002584B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFeatureSwitchScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.switchInfoList_.Add(other.switchInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E273 RID: 57971 RVA: 0x0025A2E7 File Offset: 0x002584E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E274 RID: 57972 RVA: 0x0025A2F0 File Offset: 0x002584F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.switchInfoList_.AddEntriesFrom(ref input, UpdateFeatureSwitchScNotify._repeated_switchInfoList_codec);
				}
			}
		}

		// Token: 0x04005A06 RID: 23046
		private static readonly MessageParser<UpdateFeatureSwitchScNotify> _parser = new MessageParser<UpdateFeatureSwitchScNotify>(() => new UpdateFeatureSwitchScNotify());

		// Token: 0x04005A07 RID: 23047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A08 RID: 23048
		public const int SwitchInfoListFieldNumber = 9;

		// Token: 0x04005A09 RID: 23049
		private static readonly FieldCodec<FeatureSwitchInfo> _repeated_switchInfoList_codec = FieldCodec.ForMessage<FeatureSwitchInfo>(74U, FeatureSwitchInfo.Parser);

		// Token: 0x04005A0A RID: 23050
		private readonly RepeatedField<FeatureSwitchInfo> switchInfoList_ = new RepeatedField<FeatureSwitchInfo>();
	}
}
